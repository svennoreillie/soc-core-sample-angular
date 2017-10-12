using System.Collections.Generic;

namespace GW.Zorg.Web.Business.Models {
    public enum ResultCode {
        Ok,
        Error,
        Warning,
    }

    public class Result<T> where T : new() {
        
        public Result() {
            this.Messages = new List<string>();
        }

        public Result(T value) : this() {
            this.Value = value;
        }   

        public T Value { get; set; }
        public ResultCode Code { get; set; }
        public List<string> Messages { get; set; }

        public Result<T> AddMessage(string message) {
            if (this.Messages == null) this.Messages = new List<string>();
            this.Messages.Add(message);
            return this;
        }
    }
}