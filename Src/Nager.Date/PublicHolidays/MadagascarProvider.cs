﻿using Nager.Date.Model;
using System.Collections.Generic;
using System.Linq;

namespace Nager.Date.PublicHolidays
{
    public class MadagascarProvider : CatholicBaseProvider
    {
        public override IEnumerable<PublicHoliday> Get(int year)
        {
            //Madagascar
            //https://en.wikipedia.org/wiki/Public_holidays_in_Madagascar

            var countryCode = CountryCode.MG;
            var easterSunday = base.EasterSunday(year);

            var items = new List<PublicHoliday>();
            items.Add(new PublicHoliday(year, 1, 1, "New Year's Day", "New Year's Day", countryCode));
            items.Add(new PublicHoliday(year, 3, 29, "Martyrs' Day", "Martyrs' Day", countryCode));
            items.Add(new PublicHoliday(easterSunday.AddDays(1), "Easter Monday", "Easter Monday", countryCode));
            items.Add(new PublicHoliday(year, 5, 1, "Labour Day", "Labour Day", countryCode));
            items.Add(new PublicHoliday(easterSunday.AddDays(39), "Ascension Day", "Ascension Day", countryCode));
            items.Add(new PublicHoliday(easterSunday.AddDays(50), "Whit Monday", "Whit Monday", countryCode));
            items.Add(new PublicHoliday(year, 6, 26, "Independence Day", "Independence Day", countryCode));
            items.Add(new PublicHoliday(year, 8, 15, "Assumption Day", "Assumption Day", countryCode));
            items.Add(new PublicHoliday(year, 11, 1, "All Saints' Day", "All Saints' Day", countryCode));
            items.Add(new PublicHoliday(year, 12, 25, "Christmas Day", "Christmas Day", countryCode));

            return items.OrderBy(o => o.Date);
        }
    }
}
