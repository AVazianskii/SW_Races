using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Races_libs
{
    public class Zabrak_race : Race_class
    {
        #region // переменные класса 
        #endregion
        #region // конструктор класса
        public Zabrak_race() 
        {
            Set_race_name("Забрак");               // Устанавливаем текущее показатель атрибута 
            Set_race_code((int)Race_enumerator.enum_Races._Zabrak);                       // Устанавливаем идентификатор расы
            Set_img_path(@"D:\STAR WARS Saga\Character_creation\Races_Libs\Races_lib\SW_Races\Pictures\Zabrak.jpg");                       // Устанавливаем путь к картинке расы
            
        }
        #endregion

        #region // определяем значения констант класса

        #endregion

        #region // Определяем особенности данного атрибута (если они есть)
        #endregion
    }
}
