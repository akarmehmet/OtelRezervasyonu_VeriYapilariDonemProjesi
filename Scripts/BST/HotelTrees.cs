using OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.BST;
using OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.Interfaces;
using OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.Models;
using System.Collections.Generic;
using System.Linq;

namespace OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.ConcreteClass
{
    public class HotelTrees  : BSTrees<AccommodationPlace, string>, ISearcAccommodationPlaceByProvinceAndDistrict
    {
        enum SortOrder{
            Star,
            Score,
            None
        }

        private List<AccommodationPlace> nodes;
        private string _province;
        private string _district;
        private SortOrder sortOrder;
        public HotelTrees()
        {
            nodes = new List<AccommodationPlace>();
        }

        public List<AccommodationPlace> GetAccommodationPlacesInProvinceAndDistrictOrderByScore(string province, string district)
        {
            nodes.Clear();
            _province = province;
            _district = district;
            sortOrder = SortOrder.Score;

            InOrderTrees(GetRoot());

            return nodes;
        }

        public List<AccommodationPlace> GetAccommodationPlacesInProvinceAndDistrictOrderByStar(string province, string district)
        {
            nodes.Clear();
            _province = province;
            _district = district;
            sortOrder = SortOrder.Star;


            InOrderTrees(GetRoot());

            return nodes;
        }

        public List<AccommodationPlace> GetAccommodationPlacesOrderByProvinceAndDistrict(string province, string district)
        {
            nodes.Clear();
            _province = province;
            _district = district;
            sortOrder = SortOrder.None;

            InOrderTrees(GetRoot());

            return nodes;
        }
    

        private void InOrderTrees(BSTNode<AccommodationPlace, string> node)
        {
            if (node == null)
                return;
            InOrderTrees(node.left);
            if (node.Data.Adress.District == _district && node.Data.Adress.City == _province)
            {
               
                switch (sortOrder)
                {
                    case SortOrder.Star:
                        AddByStar(node.Data);
                        break;
                    case SortOrder.Score:
                        AddByScore(node.Data);
                        break;
                    case SortOrder.None:
                        nodes.Add(node.Data);
                        break;
                    default:
                        break;
                }
            }
               
            InOrderTrees(node.right);
        }

        private void OrderByStar()
        {
            QuickSortByStarCount(nodes, 0, nodes.Count - 1);
        }

        private void OrderByScore()
        {
            QuickSortByScore(nodes, 0, nodes.Count - 1);
        }


        private void AddByScore(AccommodationPlace hotel)
        {
            bool isHotelAdded = false;
            for (int i = 0; i < nodes.Count; i++)
            {
                if (hotel.Rating >= nodes[i].Rating)
                {
                    nodes.Insert(i, hotel);
                    isHotelAdded = true;
                    break;
                }
            }

            if (!isHotelAdded)
                nodes.Add(hotel);
        }

        private void AddByStar(AccommodationPlace hotel)
        {
            bool isHotelAdded = false;
            for (int i = 0; i < nodes.Count; i++)
            {
                if (hotel.StarCount >= nodes[i].StarCount)
                {
                    nodes.Insert(i, hotel);
                    isHotelAdded = true;
                    break;
                }
            }

            if (!isHotelAdded)
                nodes.Add(hotel);
        }



        private void QuickSortByStarCount(List<AccommodationPlace> items, int altindis, int ustindis)
        {
            // altindis o adımda sıralanan altdizinin ek küçük indisidir
            // üstindis o adımda sıralanan altdizinin ek büyük indisidir
            int i = altindis, j = ustindis;

            AccommodationPlace temp;

            // pivot
            int pivot = items[(altindis + ustindis) / 2].StarCount;

            // Takas ile diziyi ayrıştırma
            do
            {
                while (items[i].StarCount < pivot)
                    i++;

                while (items[j].StarCount > pivot)
                    j--;

                if (i <= j)
                {
                    temp = items[i];
                    items[i] = items[j];
                    items[j] = temp;
                    i++;
                    j--;
                }
            } while (i <= j);

            // recursion
            if (altindis < j)
                QuickSortByStarCount(items, altindis, j);

            if (i < ustindis)
                QuickSortByStarCount(items, i, ustindis);
        }
        private void QuickSortByScore(List<AccommodationPlace> items, int altindis, int ustindis)
        {
            // altindis o adımda sıralanan altdizinin ek küçük indisidir
            // üstindis o adımda sıralanan altdizinin ek büyük indisidir
            int i = altindis, j = ustindis;
            AccommodationPlace temp;

            // pivot
            int pivot = items[(altindis + ustindis) / 2].StarCount;

            // Takas ile diziyi ayrıştırma
            do
            {
                while (items[i].Rating < pivot)
                    i++;

                while (items[j].Rating > pivot)
                    j--;

                if (i <= j)
                {
                    temp = items[i];
                    items[i] = items[j];
                    items[j] = temp;
                    i++;
                    j--;
                }
            } while (i <= j);

            // recursion
            if (altindis < j)
                QuickSortByScore(items, altindis, j);

            if (i < ustindis)
                QuickSortByScore(items, i, ustindis);
        }
    }
}
