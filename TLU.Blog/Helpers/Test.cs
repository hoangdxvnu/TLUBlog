using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TLU.Blog.Helpers
{
    public class Comment
    {
        int id;
        int parentId;
        string name;
        string anh;
        string noiDung;
        DateTime ngay;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public int ParentId
        {
            get { return parentId; }
            set { parentId = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Anh
        {
            get { return anh; }
            set { anh = value; }
        }
        public string NoiDung
        {
            get { return noiDung; }
            set { noiDung = value; }
        }
        public DateTime Ngay
        {
            get { return ngay; }
            set { ngay = value; }
        }
        public Comment(int pId, int pParentId, string pAnh, string pName, string pNoiDung, DateTime pNgay)
        {
            Id = pId;
            ParentId = pParentId;
            Name = pName;
            Anh = pAnh;
            NoiDung = pNoiDung;
            Ngay = pNgay;
        }
    }
    public class CommentModels
    {
        public static List<Comment> GetList(Comment pObject,List<Comment> pModels)
        {
            var result = pModels.Where(x => x.ParentId == pObject.Id).ToList();
            return result;
        } 
    }
}
