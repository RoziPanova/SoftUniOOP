using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public class BorderControl : BaseEntity
    {
        List<BaseEntity> entities;
        public List<BaseEntity> Entities { get { return entities; } }
        public BorderControl()
        {
            entities = new List<BaseEntity>();
        }
        public void AddEntenty(BaseEntity entity)
        {
            entities.Add(entity);
        }
    }
}
