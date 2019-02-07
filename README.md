# PatternsWinFormsExamen

Разработать систему классов, реализующую паттерны Абстрактная фабрика, Декоратор  и Цепочка обязанностей.

Классы-кафе (фабрики) (2 штуки) должны создавать объекты двух видов:   

пиццу (может быть открытая и закрытая)  и шашлык.  Для пиццы (базовый класс) нужно задавать название, к которому в производном классе добавляется тип пиццы. Также для пиццы нужно определять состав и количество ингредиентов. Для шашлыка нужно задавать вид мяса, из которого он сделан. 

В первом кафе готовят открытые пиццы с курицей, перцем и грибами, а также эти пиццы с соусом (пиццы-декораторы с дополнительной функциональностью)   и свиной шашлык.

Во втором кафе готовят закрытые пиццы с морепродуктами и сыром, а также такие же пиццы, украшенные цветами из овощей (объекты дополнительного класса-декоратора)  и шашлык из баранины.

Если в первом кафе заказывают шашлык из баранины, заказ перенаправляется во второе кафе (реализовать для этого паттерн Цепочка обязанностей).

В классе-клиенте пользователю предоставляется возможность выбрать кафе и сделать заказ. После чего ему выдается описание его заказа.

В описанное выше задание добавить реализацию паттерна Наблюдатель. 

Наблюдаемый объект – Прейскурант цен на блюда. Наблюдатели – кафе. 

У каждого кафе  своя наценочная категория, которая определяет цену на пиццу и шашлык в соответствии с прейскурантом. При изменении в прейскуранте должны «оповещаться» все наблюдатели. 
После выбора пользователем блюд ему выдается счет с описанием заказа. 
