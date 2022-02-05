using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Helicopter.Models
{
    public class DataContext : DbContext
    {
        public DbSet<AirVehicleModel> Vehicles { get; set; }
        public DbSet<UserModel> Users { get; set; }
        public DataContext(DbContextOptions<DataContext> dbContextOptions) : base(dbContextOptions)
        {
            Database.EnsureCreated();
            if (!Vehicles.Any())
            {
                Vehicles.Add(new AirVehicleModel
                {
                    Name = "DJI Mavic 3 Cine Premium Combo",
                    Price = 492990,
                    HasItCamera = true,
                    MaxHorizontalSpeed = 21,
                    MaxVerticalSpeed = 8,
                    QuantityOfMotors = 4,
                    QuantityOfPropellers = 4,
                    WorkingHours = 46,
                    Description = "Снимайте легендарный контент с помощью камеры Hasselblad CMOS 4/3 и наслаждайтесь плавным полетом с всенаправленным распознаванием препятствий. Каждое обновление DJI Mavic 3 устанавливает новый стандарт аэрофотосъемки. Летайте с Mavic 3 и откройте для себя съемку нового уровня.",
                    FirstPhoto = "../images/Kvadro/11.jpg",
                    SecondPhoto = "../images/Kvadro/12.jpg",
                    ThirdPhoto = "../images/Kvadro/13.jpg",
                    FourthPhoto = "../images/Kvadro/14.jpg"
                });
                Vehicles.Add(new AirVehicleModel
                {
                    Name = "Phantom 4 RTK",
                    Price = 574800,
                    HasItCamera = true,
                    MaxHorizontalSpeed = 16,
                    MaxVerticalSpeed = 6,
                    QuantityOfMotors = 4,
                    QuantityOfPropellers = 4,
                    WorkingHours = 30,
                    Description = "Уникальная новая модель дрона из серии DJI Phantom 4, оснащенная модулем RTK, для выполнения геодезических, картографических и инспекционных задач. Обеспечивает высокую точность и производительность.",
                    FirstPhoto = "../images/Kvadro/21.jpg",
                    SecondPhoto = "../images/Kvadro/22.jpg",
                    ThirdPhoto = "../images/Kvadro/23.jpg",
                    FourthPhoto = "../images/Kvadro/24.jpg"
                });
                Vehicles.Add(new AirVehicleModel
                {
                    Name = "Matrice 200 Серия V2",
                    Price = 1200000,
                    HasItCamera = true,
                    MaxHorizontalSpeed = 20,
                    MaxVerticalSpeed = 5,
                    QuantityOfMotors = 4,
                    QuantityOfPropellers = 4,
                    WorkingHours = 33,
                    Description = "Универсальная платформа для повышения эффективности использования дронов отличается прочностью и легкостью применения в различных отраслях промышленности. Улучшения серии M200 V2 охватывают системы управления, полетные характеристики, а также безопасность полета и данных.",
                    FirstPhoto = "../images/Kvadro/31.png",
                    SecondPhoto = "../images/Kvadro/32.png",
                    ThirdPhoto = "../images/Kvadro/33.jpg",
                    FourthPhoto = "../images/Kvadro/34.jpg"
                });
                Vehicles.Add(new AirVehicleModel
                {
                    Name = "4DRC V4",
                    Price = 5000,
                    HasItCamera = true,
                    MaxHorizontalSpeed = 10,
                    MaxVerticalSpeed = 3,
                    QuantityOfMotors = 4,
                    QuantityOfPropellers = 4,
                    WorkingHours = 20,
                    Description = "Квадрокоптер 4DRC V4 1080p имеет очень компактный складной дизайн. Он легко помещается в небольшой руке. Квадрокоптер выглядит просто, но стильно. Он подходит как для взрослых, так и детей старше 8 лет. Несмотря на свой небольшой размер квадрокоптер V4 имеет много полезных функций, таких как точное удержание высоты и режим полета без головы. Кроме того, он имеет три скорости и съемные защитные лопасти. V4 может управляться либо с помощью прилагаемого пульта дистанционного управления, либо с помощью вашего смартфона. V4 имеет аккумулятор емкостью 1600 мАч. Одного заряда батареи хватает до 20 минут полета. Разрешение видео в 1080p. Угол обзора составляет 110 градусов. Передняя камера двигается на 90 градусов вверх/вниз. V4 способен летать на расстояние около 100 м от пульта дистанционного управления. Тем не менее, этого достаточно, чтобы сделать снимки или снять видео с высоты птичьего полета.",
                    FirstPhoto = "../images/Kvadro/41.jpg",
                    SecondPhoto = "../images/Kvadro/42.jpg",
                    ThirdPhoto = "../images/Kvadro/43.jpg",
                    FourthPhoto = "../images/Kvadro/44.jpg"
                });
                Vehicles.Add(new AirVehicleModel
                {
                    Name = "DJI Mini 2 MT2PD",
                    Price = 49990,
                    HasItCamera = true,
                    MaxHorizontalSpeed = 16,
                    MaxVerticalSpeed = 5,
                    QuantityOfMotors = 4,
                    QuantityOfPropellers = 4,
                    WorkingHours = 30,
                    Description = "Чтобы сохранить уникальные события на всю жизнь в виде качественных фотографий и видео, используйте квадрокоптер DJI Mini 2. Данное устройство характеризуется небольшим весом (около 250 г) и без труда помещается в ладонь. Его удобно брать в путешествия за счет компактных размеров.",
                    FirstPhoto = "../images/Kvadro/51.jpg",
                    SecondPhoto = "../images/Kvadro/52.jpg",
                    ThirdPhoto = "../images/Kvadro/53.jpg",
                    FourthPhoto = "../images/Kvadro/54.jpg"
                });
                Vehicles.Add(new AirVehicleModel
                {
                    Name = "HIPER HQT-0002 Falcon X",
                    Price = 3000,
                    HasItCamera = false,
                    MaxHorizontalSpeed = 10,
                    MaxVerticalSpeed = 5,
                    QuantityOfMotors = 4,
                    QuantityOfPropellers = 4,
                    WorkingHours = 6,
                    Description = "Квадрокоптер HIPER Falcon X[ HQT-0002 ]+ battery среднего размера поставляется вместе с двумя аккумуляторами Li-Pol емкостью 380 мА·ч. Один элемент питания обеспечивает полет продолжительностью 6 минут. Для управления используется пульт ДУ, в который для питания устанавливаются две батарейки АА. Робот поддерживает автовзлет и автопосадку одной кнопкой, а также удержание точки высоты с помощью встроенного барометра.",
                    FirstPhoto = "../images/Kvadro/61.jpg",
                    SecondPhoto = "../images/Kvadro/62.jpg",
                    ThirdPhoto = "../images/Kvadro/63.jpg",
                    FourthPhoto = "../images/Kvadro/64.jpg"
                });
                
            }
            SaveChanges();
        }
    }
}
