w=int(input())
l=list()
for i in range(2,11):
    l.append((w/i)%2)
if 0 in l:
    print('YES')
else:
    print('NO')
