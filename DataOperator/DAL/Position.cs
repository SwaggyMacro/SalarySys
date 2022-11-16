using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataOperator.DAL
{
    
    public class Position
    {
        private DbHelper dbHelper = new DbHelper();
        public DataTable GetPositions() {
            return dbHelper.GetPositions();
        }
        public int AddPosition(Model.Position pInfo) {
            return dbHelper.AddPosition(pInfo);
        }

        public int DelPosition(int positionId)
        {
            return dbHelper.DelPosition(positionId);
        }

        public int UpdatePosition(Model.Position pInfo, int primeKey)
        {
            return dbHelper.UpdatePosition(pInfo, primeKey);
        }
    }
}
