using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Change_lang : MonoBehaviour
{
    public Button button_ru, button_kz, button_en;
    //panel left
    public Text SPK, geometry, aero, chemistry, DB, paral,setka, text1, text2;
    //text panel
    public Text text_panel;
    //camera
    public Text camera1, camera2, camera3;
    //aero
    public Text aero_t,speed,time_cycle,el_count,d_element;
    //geometry
    public Text geo_text, d1, d2, angle, kapp, blocks, visible, on, off, bt_create,bt_delete;
    //spravoch
    public Text spravoch, sprName, sprEdIzm, sprRash, sprStoi;
    //chemistry
    public Text chemisT, stepen, sostav, doo, posle,Tgasa;
    //db
    public Text adress, contactFace, project, infoCompany, CEO, nazad, vpered;
    //under panel
    public Text start, pause, reset;
    //
    public Text textBG1, textBG2;
    
    // Start is called before the first frame update
    void Start()
    {
        button_ru.onClick.AddListener(RU);
        button_kz.onClick.AddListener(KZ);
        button_en.onClick.AddListener(EN);
        SPK.text = "СПК-02-2022";
        geometry.text = "Геометрия";
        aero.text = "Аэродинамика";
        chemistry.text = "Химизм";
        DB.text = "База данных";
        paral.text = "Параллелизм";//
        setka.text = "Сетка";//
        text1.text = "Разработано в рамках реализации проекта \n ГФ AP 08 85 66 80\n «ЧИСЛЕННОЕ МОДЕЛИРОВАНИЕ КАТАЛИТИЧЕСКИХ СИСТЕМ ОЧИСТКИ\n ОТХОДЯЩИХ ГАЗОВ АВТОТРАНСПОРТА И ПРОМЫШЛЕННЫХ ПРЕДПРИЯТИЙ С\n ИСПОЛЬЗОВАНИЕМ КВАНТОВО-ХИМИЧЕСКИХ РАСЧЁТОВ И ПАРАЛЛЕЛЬНЫХ\n ВЫЧИСЛЕНИЙ»";
        text2.text = "Руководитель проекта:\nк.т.н.Хусаин Б., профессор НАН РК";//


        text_panel.text = "СПЕЦИАЛИЗИРОВАННЫЙ ПРОГРАМННЫЙ КОМПЛЕКС, ПОЗВОЛЯЮЩИЙ ОСУЩЕСТВИТЬ ПОДБОР НАИБОЛЕЕ ЭФФЕКТИВНОГО АКТИВНОЙ ФАЗЫ ДЛЯ ОБЕСПЕЧЕНИЯ МАКСИМАЛЬНОЙ СТЕПЕНИ ОЧИСТКИ, В ЗАВИСИМОСТИ ОТ ИХ ГЕОМЕТРИИ И ИСХОДНЫХ ДАННЫХ";
        
        
        camera1.text = "Камера 1";
        camera2.text = "Камера 2";
        camera3.text = "Камера 3";


        aero_t.text = "АЭРОДИНАМИКА";
        speed.text = "Скорость:";
        time_cycle.text = "Время цикла:";
        el_count.text = "Количество элементов в единицу времени:";
        d_element.text = "Диаметр элементов";
        
        
        geo_text.text = "ГЕОМЕТРИЯ";
        d1.text = "   Диаметр 1:";
        d2.text = "   Диаметр 2:";
        angle.text = "  Угол расширения:";
        kapp.text = "Размер капилляров(мм)";
        blocks.text = "Количество блоков:";
        visible.text = "Видимость Катализатора";
        on.text = "Вкл";
        off.text = "Выкл";
        bt_create.text = "Создать";
        bt_delete.text = "Удалить";

        spravoch.text = "Справочные данные для расчетов стоимости"; 
        sprName.text = "№  Наименование";
        sprEdIzm.text = "Ед. изм.";
        sprRash.text = "Расходы на единицу";
        sprStoi.text = "Стоимость";

        chemisT.text = "ХИМИЗМ";
        stepen.text = "Степень Очистки"; 
        sostav.text = "Состав газа";
        doo.text = "До";
        posle.text = "После";
        Tgasa.text = "T газа, °C";


        adress.text = "Адрес";
        contactFace.text = "Контактное лицо";
        project.text = "Проекты";
        infoCompany.text = "Сведения о компании";
        CEO.text = "Руководитель";
        nazad.text = "Назад";
        vpered.text = "Вперед";


        start.text = "Начать";
        pause.text = "Пауза";
        reset.text = "Сброс";

        textBG1.text = "Министерство науки и высшего образования Республики Казахстан \n АО «ИНСТИТУТ ТОПЛИВА, КАТАЛИЗА И ЭЛЕКТРОХИМИИ имени Д.В. СОКОЛЬСКОГО»";
        textBG2.text= "Разработано в рамках реализации проекта \n ГФ AP 08 85 66 80\n «ЧИСЛЕННОЕ МОДЕЛИРОВАНИЕ КАТАЛИТИЧЕСКИХ СИСТЕМ ОЧИСТКИ\n ОТХОДЯЩИХ ГАЗОВ АВТОТРАНСПОРТА И ПРОМЫШЛЕННЫХ ПРЕДПРИЯТИЙ С\n ИСПОЛЬЗОВАНИЕМ КВАНТОВО-ХИМИЧЕСКИХ РАСЧЁТОВ И ПАРАЛЛЕЛЬНЫХ\n ВЫЧИСЛЕНИЙ»";

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void RU()
    {
        SPK.text = "СПК-02-2022";
        geometry.text = "Геометрия";
        aero.text = "Аэродинамика";
        chemistry.text = "Химизм";
        DB.text = "База данных";
        paral.text = "Параллелизм";//
        setka.text = "Сетка";//
        text1.text = "Разработано в рамках реализации проекта \n ГФ AP 08 85 66 80\n «ЧИСЛЕННОЕ МОДЕЛИРОВАНИЕ КАТАЛИТИЧЕСКИХ СИСТЕМ ОЧИСТКИ\n ОТХОДЯЩИХ ГАЗОВ АВТОТРАНСПОРТА И ПРОМЫШЛЕННЫХ ПРЕДПРИЯТИЙ С\n ИСПОЛЬЗОВАНИЕМ КВАНТОВО-ХИМИЧЕСКИХ РАСЧЁТОВ И ПАРАЛЛЕЛЬНЫХ\n ВЫЧИСЛЕНИЙ»";
        text2.text = "Руководитель проекта:\nк.т.н.Хусаин Б., профессор НАН РК";//


        text_panel.text = "СПЕЦИАЛИЗИРОВАННЫЙ ПРОГРАМННЫЙ КОМПЛЕКС, ПОЗВОЛЯЮЩИЙ ОСУЩЕСТВИТЬ ПОДБОР НАИБОЛЕЕ ЭФФЕКТИВНОГО АКТИВНОЙ ФАЗЫ ДЛЯ ОБЕСПЕЧЕНИЯ МАКСИМАЛЬНОЙ СТЕПЕНИ ОЧИСТКИ, В ЗАВИСИМОСТИ ОТ ИХ ГЕОМЕТРИИ И ИСХОДНЫХ ДАННЫХ";


        camera1.text = "Камера 1";
        camera2.text = "Камера 2";
        camera3.text = "Камера 3";


        aero_t.text = "АЭРОДИНАМИКА";
        speed.text = "Скорость:";
        time_cycle.text = "Время цикла:";
        el_count.text = "Количество элементов в единицу времени:";
        d_element.text = "Диаметр элементов";


        geo_text.text = "ГЕОМЕТРИЯ";
        d1.text = "   Диаметр 1:";
        d2.text = "   Диаметр 2:";
        angle.text = "  Угол расширения:";
        kapp.text = "Размер капилляров(мм)";
        blocks.text = "Количество блоков:";
        visible.text = "Видимость Катализатора";
        on.text = "Вкл";
        off.text = "Выкл";
        bt_create.text = "Создать";
        bt_delete.text = "Удалить";

        spravoch.text = "Справочные данные для расчетов стоимости";
        sprName.text = "№  Наименование";
        sprEdIzm.text = "Ед. изм.";
        sprRash.text = "Расходы на единицу";
        sprStoi.text = "Стоимость";

        chemisT.text = "ХИМИЗМ";
        stepen.text = "Степень Очистки";
        sostav.text = "Состав газа";
        doo.text = "До";
        posle.text = "После";
        Tgasa.text = "T газа, °C";


        adress.text = "Адрес";
        contactFace.text = "Контактное лицо";
        project.text = "Проекты";
        infoCompany.text = "Сведения о компании";
        CEO.text = "Руководитель";
        nazad.text = "Назад";
        vpered.text = "Вперед";


        start.text = "Начать";
        pause.text = "Пауза";
        reset.text = "Сброс";

        textBG1.text = "Министерство науки и высшего образования Республики Казахстан \n АО «ИНСТИТУТ ТОПЛИВА, КАТАЛИЗА И ЭЛЕКТРОХИМИИ имени Д.В. СОКОЛЬСКОГО»";
        textBG2.text = "Разработано в рамках реализации проекта \n ГФ AP 08 85 66 80\n «ЧИСЛЕННОЕ МОДЕЛИРОВАНИЕ КАТАЛИТИЧЕСКИХ СИСТЕМ ОЧИСТКИ\n ОТХОДЯЩИХ ГАЗОВ АВТОТРАНСПОРТА И ПРОМЫШЛЕННЫХ ПРЕДПРИЯТИЙ С\n ИСПОЛЬЗОВАНИЕМ КВАНТОВО-ХИМИЧЕСКИХ РАСЧЁТОВ И ПАРАЛЛЕЛЬНЫХ\n ВЫЧИСЛЕНИЙ»";

    }

    void KZ()
    {
        SPK.text = "СПК-02-2022";
        geometry.text = "Геометрия";
        aero.text = "Аэродинамика";
        chemistry.text = "Химия";
        DB.text = "Мәліметтер базасы";

        paral.text = "Параллелизм";//
        setka.text = "Тор";//
        text1.text = "ГФ AP 08 85 66 80\n Жобаның бөлігі ретінде әзірленген \n «КВАНТТЫҚ-ХИМИЯЛЫҚ ЕСЕПТЕУЛЕРДІ ЖӘНЕ ПАРАЛЛЕЛЬДІ ЕСЕПТЕУЛЕРДІ ҚОЛДАНА ОТЫРЫП, АВТОКӨЛІК ПЕН ӨНЕРКӘСІПТІК КӘСІПОРЫНДАРДЫҢ ШЫҒАТЫН ГАЗДАРЫН ТАЗАЛАУДЫҢ КАТАЛИТИКАЛЫҚ ЖҮЙЕЛЕРІН САНДЫҚ МОДЕЛЬДЕУ»";
        text2.text = "Жоба жетекшісі:\n т.ғ.к. Хусаин Б., ҚР ҰҒА профессоры";// camera1.text = "Камера 1";

        text_panel.text = "ГЕОМЕТРИЯСЫ ЖӘНЕ БАСТАПҚЫ ДЕРЕКТЕРГЕ БАЙЛАНЫСТЫ ТАЗАЛАУДЫҢ МАКСИМАЛДЫҚ ДӘРЕЖЕСІН ҚАМТАМАСЫЗ ЕТЕТІН ЕҢ ТИІМДІ БЕЛСЕНДІ ФАЗАНЫ ТАҢДАУҒА МҮМКІНДІК БЕРЕТІН МАМАНДАНДЫРЫЛҒАН БАҒДАРЛАМАЛЫҚ КЕШЕН";



        camera1.text = "Камера 1";
        camera2.text = "Камера 2";
        camera3.text = "Камера 3";
        aero_t.text = "АЭРОДИНАМИКА";
        speed.text = "Жылдамдық:";
        time_cycle.text = "Цикл уақыты:";
        el_count.text = "Уақыт бірлігіңдегі элементтер саны :";
        d_element.text = "Элементтер диаметрі";
        geo_text.text = "ГЕОМЕТРИЯ";
        d1.text = "   Диаметр 1:";
        d2.text = "   Диаметр 2:";
        angle.text = " Кеңею бұрышы:";
        kapp.text = "Капиллярлар көлемі(мм)";
        blocks.text = "Блоктар саны:";
        visible.text = " Катализатор көрінуі";
        on.text = "Қос.";
        off.text = "Өш.";
        bt_create.text = "Жасау";
        bt_delete.text = "Жою";

        spravoch.text = "Шығындарды есептеуге арналған анықтамалық деректер";
        sprName.text = "№  Аты";
        sprEdIzm.text = "Бірлік рев.";
        sprRash.text = "Бірлік шығындары";
        sprStoi.text = "Бағасы";

        chemisT.text = "ХИМИЯ";
        stepen.text = "Тазалау дәрежесі";
        sostav.text = "Газ құрамы";
        doo.text = "Дейін";
        posle.text = "Кейін";
        Tgasa.text = "T газ, °C";


        adress.text = "Адрес";
        contactFace.text = "Байланыстағы адам";
        project.text = "Проекттер";
        infoCompany.text = "Компания туралы ақпарат";
        CEO.text = "Жетекші";
        nazad.text = "Артқа";
        vpered.text = "Алға";

        start.text = "Бастау";
        pause.text = "Тоқтату";
        reset.text = "Тастау";

        textBG1.text = "Қазақстан Республикасы Ғылым және жоғары білім министрлігі\n«Д.В.СОКОЛЬСКИЙ АТЫНДАҒЫ ОТЫН, КАТАЛИЗ ЖӘНЕ ЭЛЕКТРОХИМИЯ ИНСТИТУТЫ» АҚ";
        textBG2.text = "ГФ AP 08 85 66 80\n Жобаның бөлігі ретінде әзірленген \n «КВАНТТЫҚ-ХИМИЯЛЫҚ ЕСЕПТЕУЛЕРДІ ЖӘНЕ ПАРАЛЛЕЛЬДІ ЕСЕПТЕУЛЕРДІ ҚОЛДАНА ОТЫРЫП, АВТОКӨЛІК ПЕН ӨНЕРКӘСІПТІК КӘСІПОРЫНДАРДЫҢ ШЫҒАТЫН ГАЗДАРЫН ТАЗАЛАУДЫҢ КАТАЛИТИКАЛЫҚ ЖҮЙЕЛЕРІН САНДЫҚ МОДЕЛЬДЕУ»";

    }
    void EN()
    {
        SPK.text = "SPK-02-2022";
        geometry.text = "Geometry";
        aero.text = "Aerodynamics";
        chemistry.text = "Chemistry";
        DB.text = "Database";
        paral.text = "Parallelism";//
        setka.text = "Grid";//
        text1.text = "Developed as part of the project \n ГФ AP 08 85 66 80\n «NUMERICAL SIMULATION OF CATALYTIC SYSTEMS FOR CLEANING EXHAUST GAS OF VEHICLES AND INDUSTRIAL ENTERPRISES USING QUANTUM-CHEMICAL CALCULATIONS AND PARALLEL COMPUTING»";
        text2.text = "Project leader:\n c.t.s. Khusain B., professor of NAS RK";

        text_panel.text = "A SPECIALIZED SOFTWARE COMPLEX ALLOWING TO SELECT THE MOST EFFECTIVE ACTIVE PHASE TO ENSURE THE MAXIMUM DEGREE OF CLEANING, DEPENDING ON THEIR GEOMETRY AND INITIAL DATA";

        camera1.text = "Camera 1";
        camera2.text = "Camera 2";
        camera3.text = "Camera 3";
        aero_t.text = "AERODYNAMICS";
        speed.text = "Speed:";
        time_cycle.text = "Cycle time:";
        el_count.text = "Number of elements per unit of time:";
        d_element.text = "Element diameter";
        geo_text.text = "GEOMETRY";
        d1.text = "   Diameter 1:";
        d2.text = "   Diameter 2:";
        angle.text = "  Expansion angle:";
        kapp.text = "Capillary size(мм)";
        blocks.text = "Number of blocks:";
        visible.text = "Catalyst Visibility";
        on.text = "On";
        off.text = "Off";
        bt_create.text = "Create";
        bt_delete.text = "Delete";

        spravoch.text = "Reference data for cost calculations";
        sprName.text = "№  Name";
        sprEdIzm.text = "Unit rev.";
        sprRash.text = "Unit costs";
        sprStoi.text = "Price";

        chemisT.text = "CHEMISTRY";
        stepen.text = "Cleaning Degree";
        sostav.text = "Gas composition";
        doo.text = "Before";
        posle.text = "After";
        Tgasa.text = "T gas, °C";


        adress.text = "Address";
        contactFace.text = "The contact person";
        project.text = "Projects";
        infoCompany.text = "Company information";
        CEO.text = "Supervisor";
        nazad.text = "Back";
        vpered.text = "Forward";

        start.text = "Start";
        pause.text = "Pause";
        reset.text = "Reset";

        textBG1.text = "Ministry of Science and Higher Education of the Republic of Kazakhstan\nJSC «INSTITUTE OF FUEL, CATALYSIS AND ELECTROCHEMISTRY named after D.V. SOKOLSKY»";
        textBG2.text = "Developed as part of the project \n ГФ AP 08 85 66 80\n «NUMERICAL SIMULATION OF CATALYTIC SYSTEMS FOR CLEANING EXHAUST GAS OF VEHICLES AND INDUSTRIAL ENTERPRISES USING QUANTUM-CHEMICAL CALCULATIONS AND PARALLEL COMPUTING»";

    }
}
