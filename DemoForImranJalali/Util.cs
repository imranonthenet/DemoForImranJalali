using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoForImranJalali
{
    public class Util
    {
        public static List<ModelError> GetModelErrors(IEnumerable<KeyValuePair<string, ModelState>> modelStateDictionary)
        {
            var errorMessages = new List<ModelError>();
            foreach (var keyValuePair in modelStateDictionary)
            {
                if (keyValuePair.Value.Errors.Count > 0)
                {
                    foreach (var error in keyValuePair.Value.Errors)
                    {
                        if (!error.ErrorMessage.Contains("Info"))
                        {
                            errorMessages.Add(error);
                        }
                    }
                }

            }
            return errorMessages;
        }
    }
}