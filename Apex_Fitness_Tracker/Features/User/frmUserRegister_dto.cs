using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apex_Fitness_Tracker.Features.User
{
    class frmUserRegister_dto
    {
        private string _UserID, _UserFirstName, _UserLastName, _UserDOB, _UserGender, _UserPhno, _UserEmail, _UserPassword, _UserConfirmPw, _Userphoto;
        public string UserID
        {
            set
            {
                _UserID = value;
            }
            get
            {
                return _UserID;
            }
        }
        public string UserFirstName
        {
            set
            {
                _UserFirstName = value;
            }
            get
            {
                return _UserFirstName;
            }
        }
        public string UserLastName
        {
            set
            {
                _UserLastName = value;
            }
            get
            {
                return _UserLastName;
            }
        }
        public string UserDateofBirth
        {
            set
            {
                _UserDOB = value;
            }
            get
            {
                return _UserDOB;
            }
        }

        public string UserGender
        {
            set
            {
                _UserGender = value;
            }
            get
            {
                return _UserGender;
            }
        }
        public string UserPhNum
        {
            set
            {
                _UserPhno = value;
            }
            get
            {
                return _UserPhno;
            }
        }
        public string UserEmail
        {
            set
            {
                _UserEmail = value;
            }
            get
            {
                return _UserEmail;
            }
        }
        public string UserPassword
        {
            set
            {
                _UserPassword = value;
            }
            get
            {
                return _UserPassword;
            }
        }
        public string UserConfirmPassword
        {
            set
            {
                _UserConfirmPw = value;
            }
            get
            {
                return _UserConfirmPw;
            }
        }
        public string UserPhoto
        {
            set
            {
                _Userphoto = value;
            }
            get
            {
                return _Userphoto;
            }
        }
    }
}
