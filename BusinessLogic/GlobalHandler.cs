﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LocalTypes;
using DataAccess;

namespace BusinessLogic
{
    public class GlobalHandler
    {
        #region Data Members

        public static Dictionary<int, BaseCategoryHandler> CategoryHandlers =
            new Dictionary<int, BaseCategoryHandler>()
            {
                {1, new ExpenseCategoryHandler()},
                {2, new IncomeCategoryHandler()},
                {3, new PaymentMethodHandler()}
            };

        public static Dictionary<int, string> CategoryTypeNames =
            new Dictionary<int, string>()
            {
                {1, "Expense Categories"},
                {2, "Income Categories"},
                {3, "Payment Methods"}
            };
        
        #endregion

        #region Load Methods

        public static void IntializeData()
        {
            GlobalDataAccess.LoadAllToCache();
        }
        
        #endregion

        #region Save Methods
        
        public static void SaveData()
        {
            GlobalDataAccess.SaveAllFromCache();
        }

        #endregion
    }
}
