chicken_menu_price = 10.35
fish_menu_price = 12.40
vegan_menu_price = 8.15
delivery_price = 2.50

chicken_menu_count = int(input())
fish_menu_count = int(input())
vegan_menu_count = int(input())

total_menu_price = chicken_menu_price * chicken_menu_count + fish_menu_price * fish_menu_count + vegan_menu_price * vegan_menu_count
desert_price = total_menu_price * 0.20
total_menu_price += desert_price + delivery_price
print(total_menu_price)
