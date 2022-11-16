using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataOperator.BLL
{
    public class Position
    {
        DAL.Position position = new DAL.Position();
        public DataTable GetPositions() {
            return position.GetPositions();
        }
        public int AddPosition(Model.Position pInfo) {
            return position.AddPosition(pInfo);
        }
        public int DelPosition(int positionId)
        {
            return position.DelPosition(positionId);
        }
        public List<Model.Position> GetPositionsByList() {
            DataTable dt = position.GetPositions();
            List<Model.Position> positions = new List<Model.Position>();
            foreach (DataRow row in dt.Rows)
            {
                Model.Position p = new Model.Position()
                {
                    position_name = row[1].ToString(),
                    salary_rank = Convert.ToInt32(row[2]),
                    salary_growth = Convert.ToInt32(row[3]),
                };
                positions.Add(p);
            }
            return positions;
        }

        public int UpdatePosition(Model.Position pInfo, int primeKey)
        {
            return position.UpdatePosition(pInfo, primeKey);
        }
    }
}
