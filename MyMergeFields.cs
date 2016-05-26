using System;
using BBNCExtensions.API.Merge;

namespace FFDFrameWorkPart
{
    public class MyMergeFields : MergeFields
    {
        public enum CustomMergeFields
        {
            nameFirst,
            nameLast,
            biographical                
        };
        public MyMergeFields()
        {
            //MergeFields myFields = new MergeFields();
            bool whyBlackbaud = true;
            Fields.Add(Convert.ToInt32(CustomMergeFields.biographical), new MergeField(Convert.ToInt32(CustomMergeFields.biographical), "Biographical", 0, "Biographical data", ref whyBlackbaud, true));
            Fields.Add(Convert.ToInt32(CustomMergeFields.nameFirst), new MergeField(Convert.ToInt32(CustomMergeFields.nameFirst), "First Name", Convert.ToInt32(CustomMergeFields.biographical), "Registrant's first name", ref whyBlackbaud, true));
            Fields.Add(Convert.ToInt32(CustomMergeFields.nameLast), new MergeField(Convert.ToInt32(CustomMergeFields.nameLast), "Last Name", Convert.ToInt32(CustomMergeFields.biographical), "Registrant's last name", ref whyBlackbaud, true));
        }
    }    
}
