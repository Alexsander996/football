# Веб-сайт для управления футбольным клубом

## Содержание

[Введение](#introdution)

[1 Описание предметной области](#domainDescription)

[1.1 Цели и задачи](#Tasks)

[2 Сравнительный анализ существующих программных решений](#existSoftware)

[3 Разработка](#Development)

[4 Тестирование](#Test)

[Список используемой литературы](#Litera)

[Заключение](#End)

<a name="introdution"/>

## Введение

<a name="domainDescription"/>

Тема данного проекта - дистанционное управление футбольным клубом. Данная тема предназначена как для облегчения работы клуба, так и ускорения процессов внутри него. Данная тема крайне актуальна, так как футбол - самый популярный вид спорта на данный момент. Это не удивительно ведь футбол довольно старая игра, и играть в нее может практически кто угодно, а телеканалы и стриминговые сервисы борятся между собой за право показывать матчи клубов и сборных.

<div name = "newPage"></div>

## 1 Описание предметной области
Футбо́л — командный вид спорта, в котором целью является забить мяч в ворота соперника ногами или другими частями тела (кроме рук) большее количество раз, чем команда соперника[1]. В настоящее время самый популярный и массовый вид спорта в мире. Игрок, играющий в эту игру, — футболи́ст. Футбольный клуб — базовая ячейка всей футбольной структуры. Он является связующим звеном между футболистами, персоналом и организациями. По сути это команда футболистов, входящая в одну из организаций, имеющая определённую инфраструктуру и обслуживающий персонал. Тренер по футболу — это человек, отвечающий за слаженность игры, координатор и помощник каждого члена команды. За командными победами и поражениями стоит футбольный наставник[2].

Выбранная предметная облать - дистанционное управление клубом. Предметная область включает в себя следующие разделы: Игрок, Тренер, Болельщик. Игрок может просмотреть как расписание тренировок на неделю. Расписание составляет тренер. Игрок также может посмотреть составы на игру, и определить в какой состав он попал, а именно в основной, запасной или резервный. Также он может проверить свой баланс, который Тренер начисляет ему по контракту. Контракт составляется на основе важности роли в команде игрока и в зависимости от выделеных средств бюджета клуба на зарплаты. 

Тренер,в свою очередь, может составить подробную статистику игроков, сморя на их выполнение тренировок, физическую готовность и результативность в предыдущих играх, выдав им определенный рейтинг. Также на рейтинг влиют оценки болельщиков после матча. Игроков с хорошим рейтингом тренер определяет в один из составов на игру. Также тренер записывает команду на ближайший матч, основываясь на календаре игр, который ему предоставляет УЕФА[3].

Болельшик же может  приобрести приобрести билет, как на онлайн трансляцию, так и забранировать место на стадионе. Если болельщик приобретает билет на онлайн трансляцию, то он получает точное время трансляции и основные составы команд. Если же болельщик приобретает билет на матч, то он может распечатать билет в котором написано точное время матча, ряд и место на стадионе. В конце игры болельщик может выбрать худшего или лучшего игрока.

<a name = "Tasks"/>

## 1.1 Цели и задачи
Главная цель проекта - сделать управление клубом более удобным, быстрым и доступным.
Наладить дистанционное взаимодействие между тренером, игроками и болельщиками.
<a name = "existSoftware"/>

## 2 Сравнительный анализ существующих программных решений
Телевизионные трансляции футбольных игр всегда были популярны среди множества болельщиков футбола. Но на спортивных каналах траслируют не только один футбол. Это значит, что во время матча, на канале может идти повтор матча или вообще другой вид спорта. Также некоторые матчи могут проводится в одно и тоже время, а канал будет транслировать только один.
Еще одно решение - посетить нужный матч самому. Но это не всегда бывает удобно, из-за того что матч может проводится в другой стране или в позднее время. Также есть неколько платных сервисов с телетрансляциями матчей, например Okko[4].

Но легче всего посмотреть игру команды с сайта ее клуба. На сайте можно купить онлайн билет на один конкретный матч, а не покупать дорогую подписку как на Okko. Также сайт команды - это удобная возможность взаимодествовать тренеру с игроками команды и болельщикам дистанционно в такое непростое время. 
<a name = "Development"/>

## 3 Разработка
Начинается разработка с главных действующих лиц, а именно Тренер, игрок и болельщик. Рисуется простенькая диаграмма иллюстрирующая кто, и что сможет делать.

![image](https://user-images.githubusercontent.com/91204107/144304368-869865d9-7054-4240-83e4-a8785eaa96a8.png)
<p aling="center">
 Рисунок 1 - Use case Диаграмма
</p>
На основе этой диаграммы разработывается DFD - диаграмму [5] (см. рисунок 2).

![Рисунок11](https://user-images.githubusercontent.com/91204107/144305950-d63db309-13b0-4521-b43c-6640337d50b2.png)
<p aling="center">
 Рисунок 2 - DFD диаграмма
</p>
Оранжевым цветом помечен игрок и его действия, зеленым - тренер, красным - болельщик, фиолетовым - УЕФА

Белым цветом отмечены сущности или хранилища, на их основе составляется следующая диаграмма - ER - диаграмма [6] (см. рисунок 3).

![lkk](https://user-images.githubusercontent.com/91204107/145712072-f3c0d8f3-b1f7-4fe9-879c-2222ca95c11a.png)
<p aling="center">
Рисунок 3 - ER диаграмма
</p>
На ER - диаграмме изображены все сущности нашей программ. Каждая из сущностей имеет параметры, которые ее описывают, а также типы данных этих параметров. 

На основе этой диаграммы создаются классы в среде C# и описываются с параметрами и их типами данных (см. рисунок 4)

![image](https://user-images.githubusercontent.com/91204107/145712286-8536de9e-2d67-4b91-bec8-016a16d4bc8a.png)
<p aling="center">
Рисунок 4 - Класс "Тренер"
</p>
Создаются такие классы для всех сущностей из ER - диаграммы (см. рисунок 5)

![image](https://user-images.githubusercontent.com/91204107/144307987-eb127572-e123-4c5b-bbce-5043c95d4bbb.png)

<p aling="center">
Рисунок 5 - Список созданных классов
</p>

После создается хранилище для класса (см. рисунок 6).

![image](https://user-images.githubusercontent.com/91204107/145712485-ce7acdad-4b3e-4353-b3b8-652832cac122.png)
<p aling="center">
Рисунок 6 - Хранилище класса "Тренер"
</p>
Таким же образом создаются хранилища для остальных классов (см. рисунок 7).

![image](https://user-images.githubusercontent.com/91204107/145712525-30c2e3ee-a784-46bf-b9ab-fbeb124bdd0b.png)
<p aling="center">
Рисунок 7 - Список хранилищ классов
</p>
Далле создаются контроллеры с методами CRUD [7] (см. рисунок 8-9).

![image](https://user-images.githubusercontent.com/91204107/145712638-5bdde11c-69b2-45f8-953f-ec3228ee26d0.png)
<p aling="center">
Рисунок 8 - Контроллер класса "Тренер"
</p>
![image](https://user-images.githubusercontent.com/91204107/145712669-be31a534-5936-4012-95a0-017a38228e8c.png)
<p aling="center">
Рисунок 9 - Список созданных контроллеров
</p>
Разработка проекта завершена.


<a name = "Test"/>

## 4 Тестирование

После запуска программы открывается страница Swagger UI со списком сущностей и операций над ними (см. рисунок 10).

![image](https://user-images.githubusercontent.com/91204107/145713155-c944ea78-be67-4464-9fdf-5a20cc3eae16.png)
<p aling="center">
Рисунок 10 - Страница Swagger UI
</p>
Проверка работы методов CRUD в сущности Player (см. рисунок 11).

![image](https://user-images.githubusercontent.com/91204107/145713274-cbc256a3-9fe3-4e31-a126-51dcf793debd.png)
<p aling="center">
Рисунок 11 - Сущность Player
</p>
1. Create позволяет добавлять новые строки в вашу таблицу (см. рисунок 12).

![image](https://user-images.githubusercontent.com/91204107/145713369-54585631-f195-4665-87e1-2b392c800b74.png)
<p aling="center">
Рисунок 12 - Функция Create
</p>
Ввод необходимых данных об игроке в соответсвующие поля (см. рисунок 13).

![image](https://user-images.githubusercontent.com/91204107/145713502-507840a4-a869-4236-9fde-20fe60fc3b1f.png)
<p aling="center">
Рисунок 13 - Ввод данных в функции Create
</p>
После успешного выполнения операции ответ сервера выглядит так (см. рисунок 14). 

![image](https://user-images.githubusercontent.com/91204107/145713578-f127a3a0-22a9-42d4-8295-168009e47e49.png)
<p aling="center">
Рисунок 14 - Результат введения данных
</p>
2. Операция чтения Read извлекает определенные записи и считывать их значения (см. рисунок 15).

![image](https://user-images.githubusercontent.com/91204107/145713738-098fe738-b976-45e2-b625-93dbd01ea9f1.png)
<p aling="center">
Рисунок 15 - Функция Read
</p>
Считывание информации об уже созданном игроке по его ID (см. рисунок 16)

![image](https://user-images.githubusercontent.com/91204107/145713782-887473e8-9437-421b-b662-1abcbd61ff3a.png)
<p aling="center">
Рисунок 16 - Считывание информации
</p>
После выполнения операции сервер выдает информацию о игроке, которая была создана в Create (см. рисунок 17).

![image](https://user-images.githubusercontent.com/91204107/145713830-e5b7273c-e5d4-4381-b23c-c2847e5423d9.png)
<p aling="center">
Рисунок 17 - Выполнение операции Read
</p>
3. Функция Update редактирует существующие записи. Используется для изменения записей в базе данных (см. рисунок 18).

![image](https://user-images.githubusercontent.com/91204107/145713899-025f722d-b187-40de-b8bc-7cc946fc16c7.png)
<p aling="center">
Рисунок 18 - Операция Update
</p>
Чтобы изменить информацию о игроке, нужно сначала ввести его ID и потом новые данные (см. рисунок 19).

![image](https://user-images.githubusercontent.com/91204107/145714038-e99d6432-57cb-442c-bb9e-62aae131eeec.png)
<p aling="center">
Рисунок 19 - Изменение информации о игроке
</p>
После выполнения операции сервер выдает новую информацию о игроке с ID = 1 (см. рисунок 20).

![image](https://user-images.githubusercontent.com/91204107/145714087-3bf1d3fa-8c4f-48c3-b207-e22c5b2de30f.png)
<p aling="center">
Рисунок 20 - Вывод измененной информации
</p>
Операцией Read можно проверить результат вышеуказанной операции (см. рисунок 21).

![image](https://user-images.githubusercontent.com/91204107/145714144-cf7d0665-d78a-4006-9d2c-2146da69424a.png)
<p aling="center">
Рисунок 21 - Проверка изменения информации о игроке
</p>
4. Операция Delete используется для удаления записи по ID. Если операция удаления прошла успешно, то ответ сервера будет "true", в противном случае "false"

Удаление игрока по его ID (см. рисунок 22).

![image](https://user-images.githubusercontent.com/91204107/145714222-f1a8f201-abbf-4272-b80a-bed6eaf5a9ce.png)
<p aling="center">
Рисунок 22 - Удаление информации о игроке
</p>
После выполнения операции ответ сервера будет (см. рисунок 23).

![image](https://user-images.githubusercontent.com/91204107/145714260-4e46b867-bfc7-4f0f-8095-809abdccdafa.png)
<p aling="center">
Рисунок 23 - Результат удаления информации о игроке
</p>
<a name = "End"/>

## Заключение

Таким образом, в результате реализации данного проекта были выполнены поставленные задачи, а именно: управление клубом стало намного удобнее и быстрее, так как все нужные функции тренер может выполнять удаленно. Также было добавлено дистанционное взаимодествие между тренером, игроками и болельщиками, что облегчает коммуникацию во время пандемии. Тема данного проекта актуальна и интересна, поэтому ее дальнейшее развитие весьма перспективно.   

<div name = "newPage"></div>
<a name = "Litera"/>

## Список используемой литературы

[1] Краткий гид по игре в футбол: правила, основные термины, история[электронный ресурс]/Спорт РИА-новости - Футбол, 2021 - Режим доступа:https://rsport.ria.ru/20211023/futbol-1755915720.html, свободный (дата обращения 12.12.2021)

[2] Основные качества тренера по футболу [Электронный ресурс]// SPORT UNIVER - Основные качества тренера по футболу, Москва 2021. - Режим доступа: https://sportuniverhub.com/osnovnye-kachestva-trenera-po-futbolu, свободный (дата обращения 03.12.2021)

[3] Расшифровка аббревиатур ФИФА и УЕФА: в чем их разница? [электронный ресурс]/football-match24 - мировой футбол, 2018 - Режим доступа:https://football-match24.com/rasshifrovka-abbreviatur-fifa-i-uefa-v-chyom-ix-raznica.html, свободный (дата обращения 03.12.2021)

[4] Okko-sport-football [электронный ресурс]//Альберт Авдолян и Сергей Адоньев - стриминговый сервис, 2013 - Режим доступа: https://okko.sport/sport_collection/football, свободный (дата обращения 03.12.2021)

[5] Что такое DFD (диаграммы потоков данных)[электронный ресурс]/ramil_trinion - "Trinion" Внедрение систем ERP и CRM, 2017 - Режим доступа:https://habr.com/ru/company/trinion/blog/340064/, свободный (дата обращения 03.12.2021)

[6] Что такое ER - диаграмма и как ее создать[электронный ресурс]/Lucid - "Lucidchart" Что такое ER-диаграмма, 2021, Режим доступа:https://www.lucidchart.com/pages/ru/erd-диаграмма, свободный (дата обращения 03.12.2021)

[7] Что такое CRUD операции[электронный ресурс]/BEST PROGRAMMER - Что такое CRUD операции?, 2021 - Режим доступа:https://bestprogrammer.ru/izuchenie/chto-takoe-crud-operatsii, свободный (дата обращения 12.12.2021)
