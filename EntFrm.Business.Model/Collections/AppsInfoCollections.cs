using System.Collections;

namespace EntFrm.Business.Model.Collections
{

  public class AppsInfoCollections:CollectionBase
  {

      public AppsInfo this[int index]
      {
         get { return (AppsInfo)List[index]; }
         set { List[index] = value; }
      }

      public int Add(AppsInfo value)
      {
          return (List.Add(value));
     }

     public int IndexOf(AppsInfo value)
     {
         return (List.IndexOf(value));
     }

      public void Insert(int index, AppsInfo value)
     {
         List.Insert(index, value);
      }

     public void Remove(AppsInfo value)
    {
         List.Remove(value);
     }

    public bool Contains(AppsInfo value)
     {
       return (List.Contains(value));
     }

     public AppsInfo GetFirstOne()
     {
         return this[0];
     }

    }
  }

