using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace IndividualCounseling.Models.Project
{
    public class ProjectServices
    {
        private IndividualCounselingEntities entities;

        public ProjectServices(IndividualCounselingEntities entities)
        {
            this.entities = entities;
        }


        public IEnumerable<projectViewModle> Read()
        {
            return entities.ProjectTable.Select(db => new projectViewModle
            {
                ProjectID = db.ProjectID,
                ProjectName = db.ProjectName,
                StartDate = db.StartDate.HasValue ? db.StartDate.Value : default(DateTime),
                EndDate = db.EndDate.HasValue ? db.EndDate.Value : default(DateTime),
                Description=db.Description,
                Status=db.Status,

            
            });
        }

        public void Create(projectViewModle db)
        {
            var entity = new ProjectTable();
            entity.ProjectName = db.ProjectName;
            entity.StartDate = (DateTime)db.StartDate.Date;
            entity.EndDate = (DateTime)db.EndDate.Date;

            entity.Description = db.Description;
            entity.Status = db.Status;
            
            entities.ProjectTable.Add(entity);
            entities.SaveChanges();

            db.ProjectID = entity.ProjectID;
        }

        public void Update(projectViewModle db)
        {
            var entity = new ProjectTable();

            entity.ProjectID = db.ProjectID;
            entity.ProjectName = db.ProjectName;
            entity.StartDate = db.StartDate.Date;
            entity.EndDate = db.EndDate.Date;

            entity.Description = db.Description;
            entity.Status = db.Status;
            
            entities.ProjectTable.Attach(entity);
            entities.Entry(entity).State = EntityState.Modified;
            entities.SaveChanges();
        }


        public void Destroy(projectViewModle db)
        {
            var entity = new ProjectTable();

            entity.ProjectID = db.ProjectID;

            entities.ProjectTable.Attach(entity);

            entities.ProjectTable.Remove(entity);

            entities.SaveChanges();
        }

        public void Dispose()
        {
            entities.Dispose();
        }
    }
}