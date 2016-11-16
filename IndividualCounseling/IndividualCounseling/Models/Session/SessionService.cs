using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace IndividualCounseling.Models.Session
{
    public class SessionService
    {
        private IndividualCounselingEntities entities;

        public SessionService(IndividualCounselingEntities entities)
        {
            this.entities = entities;
        }


        public IEnumerable<SessionViewModel> Read()
        {
            return entities.Session_Table.Select(db => new SessionViewModel
            {
                sessionID = db.sessionID,
                CaseID = db.CaseID,

                sessionDate = db.sessionDate.HasValue ? db.sessionDate.Value : default(DateTime),
                sessionResult = db.sessionResult,
                sessionRecommendations = db.sessionRecommendations,



            });
        }

        public void Create(SessionViewModel db)
        {
            var entity = new Session_Table();
            entity.CaseID = db.CaseID;
            entity.sessionDate = (DateTime)db.sessionDate.Date;

            entity.sessionResult = HttpUtility.HtmlDecode(db.sessionResult);
            entity.sessionRecommendations = HttpUtility.HtmlDecode(db.sessionRecommendations);

            entities.Session_Table.Add(entity);
            entities.SaveChanges();

            db.sessionID = entity.sessionID;
        }

        public void Update(SessionViewModel db)
        {
            var entity = new Session_Table();

            entity.sessionID = db.sessionID;
            entity.CaseID = db.CaseID;
            entity.sessionDate = db.sessionDate.Date;
        

            entity.sessionResult = HttpUtility.HtmlDecode(db.sessionResult);
            entity.sessionRecommendations = HttpUtility.HtmlDecode(db.sessionRecommendations);

            entities.Session_Table.Attach(entity);
            entities.Entry(entity).State = EntityState.Modified;
            entities.SaveChanges();
        }


        public void Destroy(SessionViewModel db)
        {
            var entity = new Session_Table();

            entity.sessionID = db.sessionID;

            entities.Session_Table.Attach(entity);

            entities.Session_Table.Remove(entity);

            entities.SaveChanges();
        }

        public void Dispose()
        {
            entities.Dispose();
        }

    }
}