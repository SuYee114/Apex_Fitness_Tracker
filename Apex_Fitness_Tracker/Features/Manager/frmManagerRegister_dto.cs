using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apex_Fitness_Tracker.Features.Manager
{
    class frmManagerRegister_dto
    {
        
        private string _ManagerID, _ManagerFirstName, _ManagerLastName, _ManagerDOB,_ManagerGender, _ManagerPhno, _ManagerEmail , _ManagerPassword, _ManagerConfirmPw, _Managerphoto;
        public string ManagerID 
        {
            set
            {
                _ManagerID = value;
            }
            get
            {
                return _ManagerID;
            }
        }
        public string ManagerFirstName
        {
            set
            {
                _ManagerFirstName = value;
            }
            get
            {
                return _ManagerFirstName;
            }
        }
        public string ManagerLastName
        {
            set
            {
                _ManagerLastName = value;
            }
            get
            {
                return _ManagerLastName;
            }
        }
        public string ManagerDateofBirth
        {
            set
            {
                _ManagerDOB = value;
            }
            get
            {
                return _ManagerDOB;
            }
        }
        
        public string ManagerGender
        {
            set
            {
                _ManagerGender = value;
            }
            get
            {
                return _ManagerGender;
            }
        }
            public string ManagerPhNum
        {
            set
            {
                _ManagerPhno = value;
            }
            get
            {
                return _ManagerPhno;
            }
        }
        public string ManagerEmail
        {
            set
            {
                _ManagerEmail = value;
            }
            get
            {
                return _ManagerEmail;
            }
        }
        public string ManagerPassword
        {
            set
            {
                _ManagerPassword = value;
            }
            get
            {
                return _ManagerPassword;
            }
        }
        public string ManagerConfirmPassword
        {
            set
            {
                _ManagerConfirmPw = value;
            }
            get
            {
                return _ManagerConfirmPw;
            }
        }
        public string ManagerPhoto
        {
            set
            {
                _Managerphoto = value;
            }
            get
            {
                return _Managerphoto;
            }
        }
    }
}

    

