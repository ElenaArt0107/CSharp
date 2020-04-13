using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantExer
{
    public enum MenuItem // make it public to use inside a class
    {
        Voorgerecht,
        Hoofdgerecht,
        Nagerecht,
        MENU
    }
    public enum OrderStatus
    {
        Aangevraagt,
        Verwerkt,
        Behandeld

    }
    public class Besteling
    {
        public int tafelNr;
        public MenuItem menuItem;
        public OrderStatus status;

        public Besteling(int tn, MenuItem mi)
        {
            tafelNr = tn;
            menuItem = mi;
            status = OrderStatus.Aangevraagt;
        }
        public void VolgendeStap()
        {
            if(menuItem == MenuItem.MENU && status == OrderStatus.Aangevraagt)
            {
                status = OrderStatus.Verwerkt;
                return;
            }
            if (menuItem == MenuItem.MENU && status == OrderStatus.Verwerkt)
            {
                status = OrderStatus.Behandeld;
                return;
            }

            if (menuItem != MenuItem.MENU)
            {
                status = OrderStatus.Behandeld;
                return;
            }
        }

    }
}

