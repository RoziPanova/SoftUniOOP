using System;
using System.Collections.Generic;
using System.Text;

namespace BirthdayCelebrations
{
    public class Birthdate
    {
        List<BaseEntity> entities;
        public List<BaseEntity> Entities { get => entities; }
        public Birthdate()
        {
            entities = new List<BaseEntity>();
        }
        public void AddEntityBirthdate(BaseEntity entity)
        {
            if (entity.Birthdate != null)
            {
                Entities.Add(entity);
            }
        }
    }
}
