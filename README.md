# Веб-сайт для управления футбольным клубом

## Содержание

[Введение](#introdution)

[1. Описание предметной области](#domainDescription)

[1.1 Цели и задачи](#Tasks)

[2. Сравнительный анализ существующих программных решений](#existSoftware)

[3. Разработка](#Development)

[4. Тестирование](#Test)

[Заключение](#End)

[Список используемой литературы](#Litera)

<a name="introdution"/>

## Введение

<a name="domainDescription"/>

Тема данного проекта - дистанционное управление футбольным клубом. Данная тема предназначена как для облегчения работы клуба, так и ускорения процессов внутри него. Данная тема крайне актуальна, так как футбол - самый популярный вид спорта на данный момент. Тем более в мире еще не закончилась пандемия, и веб-сайт сделает управление клубом безопаснее. 
## 1 Описание предметной области
Футбо́л — командный вид спорта, в котором целью является забить мяч в ворота соперника ногами или другими частями тела (кроме рук) большее количество раз, чем команда соперника. В настоящее время самый популярный и массовый вид спорта в мире. Игрок, играющий в эту игру, — футболи́ст. Футбольный клуб — базовая ячейка всей футбольной структуры. Он является связующим звеном между футболистами, персоналом и организациями. По сути это команда футболистов, входящая в одну из организаций, имеющая определённую инфраструктуру и обслуживающий персонал. [1] Тренер по футболу — это человек, отвечающий за слаженность игры, координатор и помощник каждого члена команды. За командными победами и поражениями стоит футбольный наставник. [2]

Выбранная предметная облать - дистанционное управление клубом. Предметная область включает в себя следующие разделы: Игрок, Тренер, Болельщик. Игрок может просмотреть как расписание тренировок на неделю. Расписание составляет тренер. Игрок также может посмотреть составы на игру, и определить в какой состав он попал, а именно в основной, запасной или резервный. Также он может проверить свой баланс, который Тренер начисляет ему по контракту. Контракт составляется на основе важности роли в команде игрока и в зависимости от выделеных средств бюджета клуба на зарплаты. 

Тренер,в свою очередь, может составить подробную статистику игроков, сморя на их выполнение тренировок, физическую готовность и результативность в предыдущих играх, выдав им определенный рейтинг. Также на рейтинг влиют оценки болельщиков после матча. Игроков с хорошим рейтингом тренер определяет в один из составов на игру. Также тренер записывает команду на ближайший матч, основываясь на календаре игр, который ему предоставляет УЕФА[3].

Болельшик же может  приобрести приобрести билет, как на онлайн трансляцию, так и забранировать место на стадионе. Если болельщик приобретает билет на онлайн трансляцию, то он получает точное время трансляции и основные составы команд. Если же болельщик приобретает билет на матч, то он может распечатать билет в котором написано точное время матча , ряд и место на стадионе. В конце игры болельщик может выбрать худшего или лучшего игрока.

<a name = "Tasks"/>

## 1.1 Цели и задачи
Главная цель проекта - сделать управление клубом более удобным, быстрым и доступным.
Наладить дистанционное взаимодействие между тренером, игроками и болельщиками.
<a name = "existSoftware"/>

## 2 Сравнительный анализ существующих программных решений
Телевизионные трансляции футбольных игр всегда были популярны среди множества болельщиков футбола. Но на спортивных каналах траслируют не только один футбол. Это значит, что во время матча, на канале может идти повтор матча или вообще другой вид спорта. Также некоторые матчи могут проводится в одно и тоже время, а канал будет транслировать только один.
Еще одно решение - посетить нужный матч самому. Но это не всегда бывает удобно, из-за того что матч может проводится в другой стране или в позднее время. Также есть неколько платных сервисов с телетрансляциями матче, например Okko[4].

Но легче всего посмотреть игру команды с сайта ее клуба. На сайте можно купить онлайн билет на один конкретный матч, а не покупать дорогую подписку как на Okko. Также сайт команды - это удобная возможность взаимодествовать тренеру с игроками команды и болельщикам дистанционно в такое непростое время. 
<a name = "Development"/>

## 3 Разработка
Начнем разработку с главных действующих лиц, а именно Тренер, игрок и болельщик. Нарисуем простенькую диаграмму иллюстрирующую кто, и что сможет делать.
![image](https://user-images.githubusercontent.com/91204107/144304368-869865d9-7054-4240-83e4-a8785eaa96a8.png)

На основе этой диаграммы разработаем DFD - диаграмму [5] с помощью которой будем работать далее:
![Рисунок11](https://user-images.githubusercontent.com/91204107/144305950-d63db309-13b0-4521-b43c-6640337d50b2.png)
Оранжевым цветом помечен игрок и его действия, зеленым - тренер, красным - болельщик, фиолетовым - УЕФА

Белым цветом отмечены сущности или хранилища, на их основе мы будем составлять следующую диаграмму - ER - диаграмму [6]:
![lkk](https://user-images.githubusercontent.com/91204107/145712072-f3c0d8f3-b1f7-4fe9-879c-2222ca95c11a.png)
На ER - диаграмме изображены все сущности нашей программ. Каждая из сущностей имеет параметры, которые ее описывают, а также типы данных этих параметров. 

На основе этой диаграммы мы создаем классы в среде C# и описываем их с параметрами и их типами данных. Для этого мы создаем контроллер, определяем его в определенное простраство имен и описываем класс:
![image](https://user-images.githubusercontent.com/91204107/144307825-e57f2801-5d91-473f-b9c8-a23e7aaed72e.png)

Создаем такие классы для всех сущностей из ER - диаграммы:

![image](https://user-images.githubusercontent.com/91204107/144307987-eb127572-e123-4c5b-bbce-5043c95d4bbb.png)





<a name = "Test"/>

## 4 Тестирование

<a name = "End"/>

## Заключение

<a name = "Litera"/>

## Список используемой литературы

[1] https://ru.wikipedia.org/wiki/Футбол

[2] https://sportuniverhub.com/osnovnye-kachestva-trenera-po-futbolu

[3] https://football-match24.com/rasshifrovka-abbreviatur-fifa-i-uefa-v-chyom-ix-raznica.html

[4] https://okko.sport/sport_collection/football

[5] https://habr.com/ru/company/trinion/blog/340064/

[6] https://www.lucidchart.com/pages/ru/erd-диаграмма
