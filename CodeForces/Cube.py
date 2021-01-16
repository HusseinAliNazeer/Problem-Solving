from math import sqrt
def proper_round(num, dec=0):
    num = str(num)[:str(num).index('.')+dec+2]
    if num[-1]>='5':
        return float(num[:-2-(not dec)]+str(int(num[-2-(not dec)])+1))
    return float(num[:-1])
t=int(input())
for i in range(0,t):
    area=int(input())
    print(int(proper_round(sqrt(area/6))))
