budget = float(input())
video_cards_count = int(input())
cpu_count = int(input())
ram_count = int(input())

video_card_price = 250
total_sum_video_cards = video_card_price * video_cards_count
cpu_price = total_sum_video_cards * 0.35
ram_price = total_sum_video_cards * 0.10

total_sum_cpu = cpu_price * cpu_count
total_sum_ram = ram_price * ram_count

total_sum = total_sum_video_cards + total_sum_ram + total_sum_cpu

if video_cards_count > cpu_count:
    total_sum *= 0.85

left_money = abs(budget - total_sum)

if total_sum <= budget:
    print(f'You have {left_money:.2f} leva left!')
else:
    print(f'Not enough money! You need {left_money:.2f} leva more!')
