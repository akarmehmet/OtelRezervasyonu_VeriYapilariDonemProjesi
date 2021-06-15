using OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.AppData;
using OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.BST;
using OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.Interfaces;
using OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.Models;
using System;
using System.Collections.Generic;

namespace OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.ConcreteClass
{
    public class AdminHotelCrudOperations : IDbAdminAccomodationPlaceCrudOperations
    {

        private HotelData hotelData;

        public AdminHotelCrudOperations()
        {
            hotelData = HotelData.Instance;
        }


        public bool DeleteAccommodationPlace(string deletedAccommodationPlaceName)
        {
            return hotelData.HotelsData.Delete(deletedAccommodationPlaceName);
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

        public bool SaveNewAccomodationPlace(AccommodationPlace addedAccommodationPlace)
        {
            BSTNode<AccommodationPlace, string> bSTNode = new BSTNode<AccommodationPlace, string>(addedAccommodationPlace, addedAccommodationPlace.Name);

            hotelData.HotelsData.AddNode(bSTNode);
            return true;
        }

        public bool UpdateAccommodationPlace(AccommodationPlace updatedAccommodationPlace)
        {
            BSTNode<AccommodationPlace, string> bSTNode = hotelData.HotelsData.Search(updatedAccommodationPlace.Name);

            if (bSTNode != null)
            {
                bSTNode.Data = updatedAccommodationPlace;
                return true;
            }
            else
                return false; // otel not found exception.
        }

        public List<AccommodationPlace> GetAccommodationPlacesByInOrder()
        {
            return hotelData.HotelsData.InOrder();
        }

        public bool AddNewRoomToAccommodationPlace(string capacity, string hotelName, string landscapeInfo, string phone, string price, string roomNo)
        {
            BSTNode<AccommodationPlace, string> bSTNode = hotelData.HotelsData.Search(hotelName);

            if (bSTNode != null)
            {
                bool isRoomExist = false;


                foreach (var room in bSTNode.Data.Rooms)
                {
                    if (room.RoomNumber == Convert.ToInt32(roomNo))
                    {
                        isRoomExist = true;
                        break;
                    }

                }
                if (!isRoomExist)
                {
                    bSTNode.Data.Rooms.Add(
                                           new HotelRoom()
                                           {
                                               RoomNumber = Convert.ToInt32(roomNo),
                                               PhoneNumber = "04",
                                               Capacity = 3,
                                               Price = 1500,
                                               RoomLandscapeInformation = "Sea",
                                               ReservationStatus = false
                                           });
                    return true;
                }
                else
                    return false;
                   
            }
            else
                return false; // otel not found exception.
        }

        public bool DeleteRoomFromAccommodationPlace(string hotelName, string roomNo)
        {
            throw new NotImplementedException();
        }
    }
}
