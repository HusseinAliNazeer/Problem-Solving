int centuryFromYear(int year) {
           if (year<100)
            {
                return  1;
            
            }
           Double d = Convert.ToDouble(year);
            double cen = (year / 100.0);
            int cen1 = Convert.ToInt32(year / 100);
            if (cen % cen1 > 0)
            {
                cen1++;
            }
            Console.WriteLine(cen1);
            return cen1;
}
