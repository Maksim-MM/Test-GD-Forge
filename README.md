Позиции в магазине настраиваемые, с возможностью масштабирования списка предметов. 
Для этого нужно:
 1. В папке Scriptable Object продублировать уже имеющийся предмет, внести информацию добавляемого предмета в поля описания (название, описание, цену) и добавить его в лист предметов "Canvas Store/Shop/Shop Items SO". Или создать новый файл в папке вызовом меню ПКМ "Create/Scriptable Object/New Shop Item" 
 2. В Game Object "Canvas Store/Shop/Scroll Rect/Content" продублировать шаблон товара, переместить его в списки "Canvas Store/Shop/Shop Panel GO" и  "Canvas Store/Shop/Shop Panel"
 3. Добавить кнопку покупки товара Purchase Btn путем добавления ее из нового добавленного шаблона Item Template в список "Canvas Store/Shop/My Purchase Btns"

