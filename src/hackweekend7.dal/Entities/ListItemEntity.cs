using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackweekend7.dal.Entities
{
    public class ListItemEntity
    {
        public class Metadata
        {
            public string id { get; set; }
            public string uri { get; set; }
            public string etag { get; set; }
            public string type { get; set; }
        }

        public class Deferred
        {
            public string uri { get; set; }
        }

        public class FirstUniqueAncestorSecurableObject
        {
            public Deferred __deferred { get; set; }
        }

        public class Deferred2
        {
            public string uri { get; set; }
        }

        public class RoleAssignments
        {
            public Deferred2 __deferred { get; set; }
        }

        public class Deferred3
        {
            public string uri { get; set; }
        }

        public class AttachmentFiles
        {
            public Deferred3 __deferred { get; set; }
        }

        public class Deferred4
        {
            public string uri { get; set; }
        }

        public class ContentType
        {
            public Deferred4 __deferred { get; set; }
        }

        public class Deferred5
        {
            public string uri { get; set; }
        }

        public class GetDlpPolicyTip
        {
            public Deferred5 __deferred { get; set; }
        }

        public class Deferred6
        {
            public string uri { get; set; }
        }

        public class FieldValuesAsHtml
        {
            public Deferred6 __deferred { get; set; }
        }

        public class Deferred7
        {
            public string uri { get; set; }
        }

        public class FieldValuesAsText
        {
            public Deferred7 __deferred { get; set; }
        }

        public class Deferred8
        {
            public string uri { get; set; }
        }

        public class FieldValuesForEdit
        {
            public Deferred8 __deferred { get; set; }
        }

        public class Deferred9
        {
            public string uri { get; set; }
        }

        public class File
        {
            public Deferred9 __deferred { get; set; }
        }

        public class Deferred10
        {
            public string uri { get; set; }
        }

        public class Folder
        {
            public Deferred10 __deferred { get; set; }
        }

        public class Deferred11
        {
            public string uri { get; set; }
        }

        public class ParentList
        {
            public Deferred11 __deferred { get; set; }
        }

        public class Result
        {
            public Metadata __metadata { get; set; }
            public FirstUniqueAncestorSecurableObject FirstUniqueAncestorSecurableObject { get; set; }
            public RoleAssignments RoleAssignments { get; set; }
            public AttachmentFiles AttachmentFiles { get; set; }
            public ContentType ContentType { get; set; }
            public GetDlpPolicyTip GetDlpPolicyTip { get; set; }
            public FieldValuesAsHtml FieldValuesAsHtml { get; set; }
            public FieldValuesAsText FieldValuesAsText { get; set; }
            public FieldValuesForEdit FieldValuesForEdit { get; set; }
            public File File { get; set; }
            public Folder Folder { get; set; }
            public ParentList ParentList { get; set; }
            public int FileSystemObjectType { get; set; }
            public int Id { get; set; }
            public int ID { get; set; }
            public string ContentTypeId { get; set; }
            public string Title { get; set; }
            public string Modified { get; set; }
            public string Created { get; set; }
            public int AuthorId { get; set; }
            public int EditorId { get; set; }
            public string OData__UIVersionString { get; set; }
            public bool Attachments { get; set; }
            public string GUID { get; set; }
            public string Body { get; set; }
            public object Expires { get; set; }
        }

        public class D
        {
            public List<Result> results { get; set; }
        }

        public class RootObject
        {
            public D d { get; set; }
        }
    }

}
