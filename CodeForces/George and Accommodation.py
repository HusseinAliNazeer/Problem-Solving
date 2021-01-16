n=int(input())
count=0
for i in range(0,n):
    l=input().split()
    p=int(l[0])
    q=int(l[1])
    if (q - p)  >= 2 :
        count+=1
print(count)
