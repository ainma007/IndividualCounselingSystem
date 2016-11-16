using IndividualCounseling.Models.Foreignkey;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace IndividualCounseling.Models.ProjectControl
{
    public class ProjectControlService
    {
        private IndividualCounselingEntities entities;
        public ProjectControlService(IndividualCounselingEntities entities)
        {
            this.entities = entities;
        }

        public IEnumerable<ProjectControlViewModel> Readproject()
        {
            //  يجب ان يكون المشروع فعال 
            return entities.ProjectControl_Table
                        .Select(control => new ProjectControlViewModel
                        {
                            ID = control.ProjectControlID,
                            ProID = control.ProjectID,
                            UserID = control.UserID,



                            projects = new ProjectforeignKeyViewModel()
                            {
                                ProjectID = control.ProjectTable.ProjectID,
                                ProjectName = control.ProjectTable.ProjectName
                            },

                            Users = new userforeignKeyViewModel()
                            {
                                UserID = control.Users_Table.UserID,
                                FullName = control.Users_Table.FullName
                            },

                            Status = control.status,
                        });
        }



        public IEnumerable<IndexUserProjectViewModel> ReadIndexUserproject()
        {
            //  يجب ان يكون المشروع فعال 
            return entities.ProjectControl_Table
                        .Select(control => new IndexUserProjectViewModel
                        {
                            ID = control.ProjectControlID,
                            UserID = control.UserID,
                            ProID = control.ProjectID,
                            ProjectName = control.ProjectTable.ProjectName,
                            startdate = control.ProjectTable.StartDate.HasValue ? control.ProjectTable.StartDate.Value : default(DateTime),
                            endDate = control.ProjectTable.EndDate.HasValue ? control.ProjectTable.EndDate.Value : default(DateTime),
                            Description =control.ProjectTable.Description,
                            Status=control.status,


                         
                        });
        }

        public void Createproject(ProjectControlViewModel control)
        {
            try
            {
                //  تم اضافة هذا الاستعلام لعدم تكرار المشروع للمستخدم
                var project = entities.ProjectControl_Table
                             .Single(i => i.UserID == control.UserID
                                         && i.ProjectID == control.ProID);
                control.ID = 0;
            }
            catch (Exception)
            {
                var entity = new ProjectControl_Table();

                entity.ProjectID = control.ProID;
                entity.UserID = control.UserID;
                entity.status = control.Status;

                entities.ProjectControl_Table.Add(entity);
                entities.SaveChanges();

                control.ID = entity.ProjectControlID;
            }

        }

        public void Updateproject(ProjectControlViewModel control)
        {
            var entity = new ProjectControl_Table();

            entity.ProjectControlID = control.ID;
            entity.ProjectID = control.ProID;
            entity.UserID = control.UserID;
            entity.status = control.Status;

            entities.ProjectControl_Table.Attach(entity);
            entities.Entry(entity).State = EntityState.Modified;
            entities.SaveChanges();
        }

        public void Destroyproject(ProjectControlViewModel product)
        {
            var entity = new ProjectControl_Table();

            entity.ProjectControlID = product.ID;

            entities.ProjectControl_Table.Attach(entity);

            entities.ProjectControl_Table.Remove(entity);

            entities.SaveChanges();
        }

        public IEnumerable<ProjectforeignKeyViewModel> ReadProject()
        {
            return entities.ProjectTable.Select(project => new ProjectforeignKeyViewModel
            {
                ProjectID = project.ProjectID,
                ProjectName = project.ProjectName


            });
        }



        public IEnumerable<userforeignKeyViewModel> GetUseres()
        {
            //  هنا كمان   تم التعديل على حالة المستخدم 
            return entities.Users_Table
                .Where(i => i.Status != false).Select(user => new userforeignKeyViewModel
                {
                    UserID = user.UserID,
                    FullName = user.FullName,



                });
        }

      
        public void Dispose()
        {
            entities.Dispose();
        }
    }
}