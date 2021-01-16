s=0 
while True:
    arr=input().split()
    n=int(arr[0])
    m=int(arr[1])
    s=0
    if n<=0 or m<=0:
        break
    if n<=m: 
        for i in range(n,m+1):
            if n<=0 or m<=0:
                break
            print(i,end=' ')
            s+=i
    if n>m:
         for i in range(m,n+1):
            if n<=0 or m<=0:
                break
            print(i,end=' ')
            s+=i
    if s==0:
        pass
    else:
        print(f'sum ={s}')
 
