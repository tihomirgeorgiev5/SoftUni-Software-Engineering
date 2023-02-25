count_pens = int(input())
count_markers = int(input())
liters_detergent = int(input())
discount = int(input())

pens_price = 5.80
markers_price = 7.20
detergent_price = 1.20

total_pens_price = count_pens * pens_price
total_markers_price = count_markers * markers_price
total_detergent_price = detergent_price * liters_detergent

total_sum = total_detergent_price + total_markers_price + total_pens_price
total_sum_after_discount = total_sum - (total_sum * discount / 100)

print(total_sum_after_discount)