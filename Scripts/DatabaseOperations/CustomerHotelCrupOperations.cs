using OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.AppData;
using OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.BST;
using OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.Interfaces;
using OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.Models;
using System;
using System.Collections.Generic;

namespace OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.DatabaseOperations
{
    public class CustomerHotelCrupOperations : IDbCustomerAccomodationPlaceCrudOperations
    {
        private HotelData hotelData;
        public CustomerHotelCrupOperations()
        {

            hotelData = HotelData.Instance;

        }

        public List<AccommodationPlace> GetAccommodationPlacesByInOrder()
        {
            return hotelData.HotelsData.InOrder();
        }

        public List<AccommodationPlace> GetAccommodationPlacesByPostOrder()
        {
            return hotelData.HotelsData.PostOrder();
        }

        public List<AccommodationPlace> GetAccommodationPlacesByPreOrder()
        {
            return hotelData.HotelsData.PreOrder();
        }

        public int GetAccommodationPlacesCount()
        {
            return hotelData.HotelsData.NodeCount();
        }

        public int GetAccommodationPlacesDepth()
        {
            return hotelData.HotelsData.LeafCount();
        }

        public List<AccommodationPlace> GetAccommodationPlacesOrderByName()
        {
            return hotelData.HotelsData.InOrder();
        }

        public List<AccommodationPlace> GetAccommodationPlacesInProvinceAndDistrictOrderByScore(string province, string district)
        {
            return hotelData.HotelsData.GetAccommodationPlacesInProvinceAndDistrictOrderByScore(province, district);
        }

        public List<AccommodationPlace> GetAccommodationPlacesInProvinceAndDistrictOrderByStar(string province, string district)
        {
            return hotelData.HotelsData.GetAccommodationPlacesInProvinceAndDistrictOrderByStar(province, district);
        }

      

        public List<AccommodationPlace> GetAccommodationPlacesOrderByProvinceAndDistrict(string province, string district)
        {
            return hotelData.HotelsData.GetAccommodationPlacesOrderByProvinceAndDistrict(province, district);
        }


        public bool MakeReservation(string nameOfAccommodationPlace)
        {
            throw new NotImplementedException();
        }

        public bool MakeCommentAndGiveScoreAccommodationPlace(string nameOfAccommodationPlace, Comment givenComment)
        {
            BSTNode<AccommodationPlace, string> hotel = hotelData.HotelsData.Search(nameOfAccommodationPlace);

            if (hotel == null)
                return false;

            bool hasCustomerCommentBefore = false;

            foreach (var comment in hotel.Data.Comments)
            {
                if (comment.CommenterEmail.Equals(givenComment.CommenterEmail))
                {
                    hasCustomerCommentBefore = true;
                    break;
                }
            }

            if (hasCustomerCommentBefore)
                return false;

            hotel.Data.Comments.Add(givenComment);
            hotel.Data.Rating += givenComment.GivenScore;
            return true;
        }

        public AccommodationPlace FindAccommodationPlace(string name)
        {
            try
            {
                return hotelData.HotelsData.Search(name).Data;
            }
            catch (Exception)
            {

                return null;
            }


        }
    }
}
