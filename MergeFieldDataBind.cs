using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace FFDFrameWorkPart
{
    public class MergeFieldsDataBind : BBNCExtensions.API.Merge.MergeData
    {
        public string nameFirst;
        public string nameLast;

        public override string GetDataForField(int fieldId)
        {
            switch ((MyMergeFields.CustomMergeFields)fieldId)
            {
                case MyMergeFields.CustomMergeFields.nameFirst :
                    return nameFirst;
                case MyMergeFields.CustomMergeFields.nameLast:
                    return nameLast;
                default:
                    return "";
            }
        }

        public MergeFieldsDataBind(string firstName, string lastName)
        {
            nameFirst = firstName;
            nameLast = lastName;
        }
    }
}
