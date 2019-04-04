using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsCarService
{
    public static class GUI_WF
    {
        private static int _selectedClientId;
        private static int _selectedAutoId;
        private static int _selectedOrderId;
        private static string _slectedOrderDescription;

        public static void SetSelectedClientId(int id)
        {
            _selectedClientId = id;
        }

        public static int GetSelectedClientId()
        {
            return _selectedClientId;
        }

        public static void SetSelectedAutoId(int id)
        {
            _selectedAutoId = id;
        }

        public static int GetSelectedAutoId()
        {
            return _selectedAutoId;
        }

        public static void SetSelectedOrderId(int id)
        {
            _selectedOrderId = id;
        }

        public static int GetSelectedOrderId()
        {
            return _selectedOrderId;
        }

        public static void SetSelectedOrderDescription(string description)
        {
            _slectedOrderDescription = description;
        }

        public static string GetSelectedOrderDescription()
        {
            return _slectedOrderDescription;
        }

    }
}
