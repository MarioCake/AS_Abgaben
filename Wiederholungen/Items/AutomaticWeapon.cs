using System;
using System.Collections.Generic;
using System.Text;

namespace Wiederholungen.Items
{
    public class AutomaticWeapon : IItem
    {
        private BattleshipsGame game;
        private Queue<string> shootPositions = new Queue<string>();

        private void LoadAmmo(string fieldPosition)
        {
            shootPositions.Enqueue(fieldPosition);
        }

        public void UseItem()
        {


        }

        public void ExecuteItem()
        {

        }

        public AutomaticWeapon(BattleshipsGame game)
        {
            this.game = game;
        }
    }
}
