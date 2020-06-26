using System.Collections;

namespace EntFrm.Business.Model.Collections
{

  public class AppsClassCollections:CollectionBase
  {

      public AppsClass this[int index]
      {
         get { return (AppsClass)List[index]; }
         set { List[index] = value; }
      }

      public int Add(AppsClass value)
      {
          return (List.Add(value));
     }

     public int IndexOf(AppsClass value)
     {
         return (List.IndexOf(value));
     }

      public void Insert(int index, AppsClass value)
     {
         List.Insert(index, value);
      }

     public void Remove(AppsClass value)
    {
         List.Remove(value);
     }

    public bool Contains(AppsClass value)
     {
       return (List.Contains(value));
     }

     public AppsClass GetFirstOne()
     {
         return this[0];
     }

    }
  }

