namespace TimeAgo;

public static class DateDiffExtensions {
    public static string AsDateDiff(this DateTime startDate, DateTime endDate, Language language = Language.English) {
        TimeSpan difference =
            (endDate > startDate)
                ? endDate - startDate
                : startDate - endDate;

        string result = "";

        if (difference.TotalDays >= 365) {
            int years = (int)Math.Floor(difference.TotalDays / 365);
            result += years + " year" + (years > 1 ? "s " : " ");
            difference = difference.Subtract(new TimeSpan(years * 365, 0, 0, 0));
        }

        if (difference.TotalDays >= 30) {
            int months = (int)Math.Floor(difference.TotalDays / 30);
            result += months + " month" + (months > 1 ? "s " : " ");
            difference = difference.Subtract(new TimeSpan(months * 30, 0, 0, 0));
        }

        if (difference.TotalDays >= 1) {
            int days = (int)Math.Floor(difference.TotalDays);
            result += days + " day" + (days > 1 ? "s " : " ");
            difference = difference.Subtract(new TimeSpan(days, 0, 0, 0));
        }

        if (difference.TotalHours >= 1) {
            int hours = (int)Math.Floor(difference.TotalHours);
            result += hours + " hour" + (hours > 1 ? "s " : " ");
            difference = difference.Subtract(new TimeSpan(0, hours, 0, 0));
        }

        if (difference.TotalMinutes >= 1) {
            int minutes = (int)Math.Floor(difference.TotalMinutes);
            result += minutes + " minute" + (minutes > 1 ? "s " : " ");
            difference = difference.Subtract(new TimeSpan(0, 0, minutes, 0));
        }

        if (difference.TotalSeconds >= 1) {
            int seconds = (int)Math.Floor(difference.TotalSeconds);
            result += seconds + " second" + (seconds > 1 ? "s " : " ");
        }

        if (language is Language.English) {
            return result;
        } else {
            return result
                .Replace("years", "ปี").Replace("months", "เดือน").Replace("days", "วัน").Replace("hours", "ชั่วโมง").Replace("minutes", "นาที").Replace("seconds", "วินาที")
                .Replace("year", "ปี").Replace("month", "เดือน").Replace("day", "วัน").Replace("hour", "ชั่วโมง").Replace("minute", "นาที").Replace("second", "วินาที");
        }
    }

}