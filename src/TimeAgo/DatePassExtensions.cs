namespace TimeAgo;

public static class DatePassExtensions {

    public static string AsTimeAgo(this DateTime dateTime, Language language = Language.Thai) {
        var timeSpan = DateTime.Now.Subtract(dateTime);

        if (language is Language.English) {
            return timeSpan.TotalSeconds switch {
                <= 60 => $"{timeSpan.Seconds} seconds ago",
                _ => timeSpan.TotalMinutes switch {
                    <= 1 => "about a minute ago",
                    < 60 => $"about {timeSpan.Minutes} minutes ago",
                    _ => timeSpan.TotalHours switch {
                        <= 1 => "about an hour ago",
                        < 24 => $"about {timeSpan.Hours} hours ago",
                        _ => timeSpan.TotalDays switch {
                            <= 1 => "yesterday",
                            <= 30 => $"about {timeSpan.Days} days ago",

                            <= 60 => "about a month ago",
                            < 365 => $"about {timeSpan.Days / 30} months ago",

                            <= 365 * 2 => "about a year ago",
                            _ => $"about {timeSpan.Days / 365} years ago"
                        }
                    }
                }
            };
        } else {
            return timeSpan.TotalSeconds switch {
                <= 60 => $"{timeSpan.Seconds} วินาทีที่แล้ว",
                _ => timeSpan.TotalMinutes switch {
                    <= 1 => "ประมาณ 1 นาทีที่แล้ว",
                    < 60 => $"ประมาณ {timeSpan.Minutes} นาทีที่แล้ว",
                    _ => timeSpan.TotalHours switch {
                        <= 1 => "ประมาณ 1 ชั่วโมงที่แล้ว",
                        < 24 => $"ประมาณ {timeSpan.Hours} ชั่วโมงที่แล้ว",
                        _ => timeSpan.TotalDays switch {
                            <= 1 => "เมื่อวานนี้",
                            <= 30 => $"ประมาณ {timeSpan.Days} วันที่แล้ว",

                            <= 60 => "ประมาณ 1 เดือนที่แล้ว",
                            < 365 => $"ประมาณ {timeSpan.Days / 30} เดือนที่แล้ว",

                            <= 365 * 2 => "ประมาณ 1 ปีที่แล้ว",
                            _ => $"ประมาณ {timeSpan.Days / 365} ปีที่แล้ว"
                        }
                    }
                }
            };
        }
    }
}