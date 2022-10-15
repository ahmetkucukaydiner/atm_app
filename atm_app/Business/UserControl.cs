using atm_app.Database;
using atm_app.Entity;

namespace atm_app.Business
{
    public class UserControl
    {
        DB db = new DB();

        public bool Controller(int customerCode, string password)
        {
            User user = db.GetCustomerCode(customerCode);

            if (user.Password == password)
                return true;
            else
                return false;
        }
    }
}
