total_sq_m = float(input())

price_sq_m = 7.61
before_discount_total_prc = total_sq_m * price_sq_m
discount = before_discount_total_prc * 0.18
after_discount_total_prc = before_discount_total_prc - discount

print(f'The final price is: {after_discount_total_prc} lv.')
print(f'The discount is: {discount} lv.')