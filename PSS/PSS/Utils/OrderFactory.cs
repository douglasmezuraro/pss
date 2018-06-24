using PSS.Models;

namespace PSS.Utils
{
    public class OrderFactory
    {
        private enum UserTypeEnum
        {
            Adminstrator,
            Client,
            Visitor
        }

        public string GetControllerName(User user)
        {
            UserTypeEnum Type = (UserTypeEnum) user.UserTypeId;
            string ControllerName;

            switch (Type)
            {
                case UserTypeEnum.Adminstrator:
                    ControllerName = "PurchaseOrders";
                    break;
                case UserTypeEnum.Client:
                    ControllerName = "SaleOrders";
                    break;
                case UserTypeEnum.Visitor:
                    ControllerName = "SaleOrders";
                    break;
                default:
                    ControllerName = "Home";
                    break;     
            }

            return ControllerName;
        }
    }
}