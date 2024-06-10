using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store2f.ViewModels
{
    internal class User
    {
        private int _id;
        public string _User_Role;

        public string _Password;
        public string _Login;
        public bool _Rights;

        public User(int _id, string _User_Role, string _Password, string _login, bool _Rights)
        {
            this._id = _id;
            this._User_Role = _User_Role;
            this._Password = _Password;
            this._Login = _login;
            this._Rights = _Rights;
        }

    }
}
