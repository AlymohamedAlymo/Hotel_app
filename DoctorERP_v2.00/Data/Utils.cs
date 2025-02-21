using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.WinControls;

namespace HotelApp.Data
{
    public static class Utils
    {
        public static Color MainThemeColor;
        public static string MainFont = "Roboto";
        public static string MainFontMedium = "Roboto Medium";

        public static int? GetHouseKeeperIdByName(string name, BindingList<HouseKeeper> houseKeepers)
        {
            int? id = null;
            foreach (HouseKeeper hk in houseKeepers)
            {
                if (hk.Name == name)
                {
                    return hk.Id;
                }
            }
            return id;
        }

        public static string GetHouseKeepingStatus(HouseKeepingStatus houseKeepingStatus)
        {
            switch (houseKeepingStatus)
            {
                case HouseKeepingStatus.Clean:
                    return "نظيف";
                case HouseKeepingStatus.NotClean:
                    return "غير نظيف";
                case HouseKeepingStatus.InProgress:
                    return "قيد التقدم";
                default:
                    return "غير متاح";
            }
        }

        public static string GetRoomType(RoomType roomType)
        {
            switch (roomType)
            {
                case RoomType.Single:
                    return "فردي";
                case RoomType.Double:
                    return "زوحي";
                case RoomType.Triple:
                    return "ثلاثي";//"Family (3)";
                case RoomType.Family:
                    return "عائلي"; //"Family (4)";
                default:
                    return "غير متاح";
            }
        }

        internal static System.Drawing.Image GetImageByRoomType(RoomType roomType)
        {
            switch (ThemeResolutionService.ApplicationThemeName)
            {
                case "Material":
                    return GetImageByRoomTypeMaterial(roomType);
                case "MaterialPink":
                    return GetImageByRoomTypeMaterialPink(roomType);
                case "MaterialTeal":
                    return GetImageByRoomTypeMaterialTeal(roomType);
                case "MaterialBlueGrey":
                    return GetImageByRoomTypeMaterialBlueGrey(roomType);
                default:
                    return DoctorERP_v2_00.Properties.Resources.free_room;
            }
        }

        internal static System.Drawing.Image GetImageByRoomTypeMaterial(RoomType roomType)
        {
            switch (roomType)
            {
                case RoomType.Single:
                    return DoctorERP_v2_00.Properties.Resources.single_user_orange;
                case RoomType.Double:
                    return DoctorERP_v2_00.Properties.Resources.double_user_orange;
                case RoomType.Triple:
                    return DoctorERP_v2_00.Properties.Resources.tripple_user_orange;
                case RoomType.Family:
                    return DoctorERP_v2_00.Properties.Resources.family_user_orange;
                default:
                    return DoctorERP_v2_00.Properties.Resources.free_room;
            }
        }

        internal static System.Drawing.Image GetImageByRoomTypeMaterialPink(RoomType roomType)
        {
            switch (roomType)
            {
                case RoomType.Single:
                    return DoctorERP_v2_00.Properties.Resources.single_user_blue;
                case RoomType.Double:
                    return DoctorERP_v2_00.Properties.Resources.double_user_blue;
                case RoomType.Triple:
                    return DoctorERP_v2_00.Properties.Resources.tripple_user_blue;
                case RoomType.Family:
                    return DoctorERP_v2_00.Properties.Resources.family_user_blue;
                default:
                    return DoctorERP_v2_00.Properties.Resources.free_room_pink;
            }
        }

        internal static System.Drawing.Image GetImageByRoomTypeMaterialTeal(RoomType roomType)
        {
            switch (roomType)
            {
                case RoomType.Single:
                    return DoctorERP_v2_00.Properties.Resources.single_user_red;
                case RoomType.Double:
                    return DoctorERP_v2_00.Properties.Resources.double_user_red;
                case RoomType.Triple:
                    return DoctorERP_v2_00.Properties.Resources.tripple_user_red;
                case RoomType.Family:
                    return DoctorERP_v2_00.Properties.Resources.family_user_red;
                default:
                    return DoctorERP_v2_00.Properties.Resources.free_room_teal;
            }
        }

        internal static System.Drawing.Image GetImageByRoomTypeMaterialBlueGrey(RoomType roomType)
        {
            switch (roomType)
            {
                case RoomType.Single:
                    return DoctorERP_v2_00.Properties.Resources.single_user_green;
                case RoomType.Double:
                    return DoctorERP_v2_00.Properties.Resources.double_user_green;
                case RoomType.Triple:
                    return DoctorERP_v2_00.Properties.Resources.tripple_user_green;
                case RoomType.Family:
                    return DoctorERP_v2_00.Properties.Resources.family_user_green;
                default:
                    return DoctorERP_v2_00.Properties.Resources.free_room_bluegrey;
            }
        }

        internal static System.Drawing.Image GetRoomIconByType(RoomType roomType)
        {
            switch (roomType)
            {
                case RoomType.Single:
                    return DoctorERP_v2_00.Properties.Resources.single_user;
                case RoomType.Double:
                    return DoctorERP_v2_00.Properties.Resources.double_users;
                case RoomType.Triple:
                    return DoctorERP_v2_00.Properties.Resources.tripple_users;
                case RoomType.Family:
                    return DoctorERP_v2_00.Properties.Resources.family_users;
                default:
                    return null;
            }
        }

        internal static System.Drawing.Image GetRoomIconByHouseKeepingStatus(HouseKeepingStatus houseKeepingStatus)
        {
            switch (houseKeepingStatus)
            {
                case HouseKeepingStatus.Clean:
                    return DoctorERP_v2_00.Properties.Resources.GlyphCheck_small;
                case HouseKeepingStatus.NotClean:
                    return DoctorERP_v2_00.Properties.Resources.GlyphClose;
                case HouseKeepingStatus.InProgress:
                    return DoctorERP_v2_00.Properties.Resources.clock_small;
                default:
                    return null;
            }
        }

        internal static Room GetRoomById(int roomId, BindingList<Room> rooms)
        {
            Room r = null;
            foreach (Room room in rooms)
            {
                if (room.Id == roomId)
                {
                    return room;
                }
            }
            return r;
        }

        internal static string GetRoomStatus(RoomStatus roomStatus)
        {
            switch (roomStatus)
            {
                case RoomStatus.Reserved:
                    return "محجوز";
                case RoomStatus.Occupied:
                    return "مشغول";
                case RoomStatus.Available:
                    return "متاح";
                case RoomStatus.CheckedOut:
                    return "تم تسجيل الخروج";
                default:
                    return "غير متاح";
            }
        }
        internal static string GetBookingStatus(BookingStatus bookingStatus)
        {
            switch (bookingStatus)
            {
                case BookingStatus.Actual:
                    return "فِعلي";
                case BookingStatus.Cancelled:
                    return "تم الإلغاء";
                case BookingStatus.CheckedOut:
                    return "تم الخروج";
                case BookingStatus.NoShow:
                    return "لا يوجد عرض";
                case BookingStatus.Reservation:
                    return "حجز";

                default:
                    return "غير متاح";
            }
        }
        internal static string GetBookingStatusStr(string bookingStatus)
        {
            switch (bookingStatus)
            {
                case "فِعلي":
                    return "Actual";
                case "تم الإلغاء":
                    return "Cancelled";
                case "تم الخروج":
                    return "CheckedOut";
                case "لا يوجد عرض":
                    return "NoShow";
                case "حجز":
                    return "Reservation";

                default:
                    return "غير متاح";
            }
        }

        internal static System.Drawing.Image GetRoomImageByRoomType(RoomType roomType)
        {
            switch (roomType)
            {
                case RoomType.Single:
                    return DoctorERP_v2_00.Properties.Resources.single;
                case RoomType.Double:
                    return DoctorERP_v2_00.Properties.Resources._double;
                case RoomType.Triple:
                    return DoctorERP_v2_00.Properties.Resources.tripple;
                case RoomType.Family:
                    return DoctorERP_v2_00.Properties.Resources.family;
                default:
                    return null;
            }
        }

        public static string GetBookingTypeByStatus(BookingStatus bk)
        {
            switch (bk)
            {
                case BookingStatus.Reservation:
                    return "حجز";
                case BookingStatus.Actual:
                    return "فِعلي";
                case BookingStatus.Cancelled:
                    return "تم الإلغاء";
                case BookingStatus.CheckedOut:
                    return "تم الخروج";
                case BookingStatus.NoShow:
                    return "عدم الحضور";
                default:
                    return "غير متاح";
            }
        }

        public static Guest GetGuestById(BindingList<Guest> guests, string id)
        {
            Guest g = null;
            foreach (Guest guest in guests)
            {
                if (guest.Id == id)
                {
                    return guest;
                }
            }
            return g;
        }

        internal static Image GetAvailableImageByTheme()
        {
            switch (ThemeResolutionService.ApplicationThemeName)
            {
                case "Material":
                    return DoctorERP_v2_00.Properties.Resources.free_room;
                case "MaterialPink":
                    return DoctorERP_v2_00.Properties.Resources.free_room_pink;
                case "MaterialTeal":
                    return DoctorERP_v2_00.Properties.Resources.free_room_teal;
                case "MaterialBlueGrey":
                    return DoctorERP_v2_00.Properties.Resources.free_room_bluegrey;
                default:
                    return DoctorERP_v2_00.Properties.Resources.free_room;
            }
        }
    }
}