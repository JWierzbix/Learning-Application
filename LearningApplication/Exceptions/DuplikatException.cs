using LearningApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LearningApplication.Exceptions
{
    public class DuplikatException : Exception
    {
        private Zestaw _istniejący_Zestaw;
        private string _nazwa_Nowego_Zestawu;
        public DuplikatException(Zestaw istniejący_Zestaw, string nazwa_Nowego_Zestaw)
        {
            _istniejący_Zestaw = istniejący_Zestaw;
            _nazwa_Nowego_Zestawu = nazwa_Nowego_Zestaw;
        }
        public DuplikatException()
        {

        }
        public DuplikatException(string message) : base(message)
        {
        }

        public DuplikatException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected DuplikatException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
