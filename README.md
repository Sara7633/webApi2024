

שרה אפשר לשנות את התמונות לתמונות אמיתיות של הפרוייקט ואפשר גם להשמיט סופי. אפשר כמובן גם לערוך, להשמיט וכו' זה רק מה שזכרתי שהמורה אמרה שצריך לשים בreadme.
סורי, אבל לא הצלחתי לפתוח את זה בבית.. אני ינסה להוסיף עיצוב יפה יותר בהמשך כשאני אבוא לסמינר.
מתגעגעת כבר (בעיקר לעצבים או למה שקורה ב-2:35:- המוקדם מבינהם:))
---

# 🛍️ פרויקט חנות מקוונת

ברוכים הבאים לפרויקט החנות המקוונת! פרויקט זה הוא יישום אינטרנט שפותח באמצעות ASP.NET Core MVC עבור צד השרת ו-HTML, CSS ו-JavaScript עבור צד הלקוח. האפליקציה כוללת חנות מקוונת עם עגלות קניות מותאמות אישית לכל משתמש, יכולות רישום ובדיקות מקיפות.

![Storefront](https://via.placeholder.com/800x400?text=Storefront)

---

## תוכן העניינים
1. [סקירת פרוייקט](#סקירת-פרוייקט)
2. [מאפיינים](#מאפיינים)
3. [טכנולוגיות בשימוש](#טכנולוגיות-בשימוש)
4. [התקנה והתקנה](#התקנה-והתקנה)
5. [נוֹהָג](#נוֹהָג)
6. [רישום](#רישום)
7. [בדיקה](#בדיקה)
8. [תורם](#תורם)
9. [רישיון](#רישיון)
10. [תודות](#תודות)

---

<div id="סקירת-פרוייקט">
  <h2>סקירת פרוייקט 🛍️</h2>
  <p>פרויקט החנות המקוונת נועד לספק חווית קנייה חלקה למשתמשים. זה מאפשר למשתמשים לעיין במוצרים, להוסיף אותם לעגלת הקניות האישית שלהם ולבצע רכישות. הלוגיקה בצד השרת מיושמת באמצעות ASP.NET Core MVC, בעוד שהממשק בצד הלקוח בנוי עם HTML, CSS ו-JavaScript.</p>
  <img src="https://via.placeholder.com/600x300?text=Shopping+Cart" alt="Shopping Cart">
</div>

<div id="מאפיינים">
  <h2>מאפיינים ⭐</h2>
  <ul>
    <li>אימות משתמש: כניסה ורישום משתמש מאובטחים.</li>
    <li>עגלת קניות מותאמת אישית: לכל משתמש יש עגלת קניות ייחודית.</li>
    <li>קטלוג מוצרים: עיון וחיפוש מוצרים.</li>
    <li>ניהול הזמנות: בצע הזמנות וצפה בהיסטוריית ההזמנות.</li>
    <li>רישום: רישום מקיף באמצעות לוגר מותאם אישית.</li>
    <li>בדיקות יחידה: הבטחת מהימנות ונכונות האפליקציה.</li>
  </ul>
</div>

<div id="טכנולוגיות-בשימוש">
  <h2>טכנולוגיות בשימוש 🛠️</h2>
  <ul>
    <li>ASP.NET Core MVC: מסגרת בצד השרת לבניית יישומי אינטרנט.</li>
    <li>ליבת מסגרת ישות: ORM לפעולות מסד נתונים.</li>
    <li>HTML, CSS, JavaScript: טכנולוגיות Front-end לבניית ממשק המשתמש.</li>
    <li>xUnit: מסגרת בדיקה עבור יישומי NET.</li>
    <li>Serilog: ספריית רישום לרישום מובנה.</li>
  </ul>
</div>

<div id="התקנה-והתקנה">
  <h2>התקנה והתקנה ⚙️</h2>
  <h3>דרישות מוקדמות</h3>
  <ul>
    <li>.NET Core SDK</li>
    <li>SQL Server או מסד נתונים נתמך אחר</li>
    <li>Node.js (לניהול תלות בצד הלקוח)</li>
  </ul>
  
  <h3>שלבים</h3>
  <ol>
    <li>שכפל את המאגר:
      <pre><code>git clone https://github.com/yourusername/online-store.git
cd online-store</code></pre>
    </li>
    <li>הגדר את מסד הנתונים:
      <pre><code>
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=YOUR_SERVER;Database=BikeStore;Trusted_Connection=True;TrustServerCertificate=True"
  }
}
      </code></pre>
    </li>
    <li>החל העברות והצג את מסד הנתונים:
      <pre><code>dotnet ef database update</code></pre>
    </li>
    <li>התקן תלויות בצד הלקוח:
      <pre><code>cd ClientApp
npm install</code></pre>
    </li>
    <li>בנה והפעל את האפליקציה:
      <pre><code>dotnet build
dotnet run</code></pre>
    </li>
    <li>פתח את הדפדפן שלך ונווט אל <a href="http://localhost:5000">http://localhost:5000</a>.</li>
  </ol>
  <img src="https://via.placeholder.com/600x300?text=Database+Setup" alt="Database Setup">
</div>

<div id="נוֹהָג">
  <h2>נוֹהָג 🧭</h2>
  <ul>
    <li>מוצרי גלישה: משתמשים יכולים לעיין בקטלוג המוצרים ולחפש פריטים ספציפיים.</li>
    <li>הוספה לעגלה: משתמשים מאומתים יכולים להוסיף מוצרים לעגלות הקניות האישיות שלהם.</li>
    <li>למקם הזמנות: משתמשים יכולים לסקור את העגלה שלהם ולבצע הזמנות. היסטוריית ההזמנות נגישה דרך פרופיל המשתמש.</li>
  </ul>
  <img src="https://via.placeholder.com/600x300?text=Browsing+Products" alt="Browsing Products">
</div>

<div id="רישום">
  <h2>רישום 📝</h2>
  <p>האפליקציה משתמשת ב-Serilog לרישום. יומנים מאוחסנים בקובץ שנמצא בכתובת <code>logs/log.txt</code> וכוללים מידע מפורט על אירועי יישומים, שגיאות ופעולות משתמש.</p>
  
  <h3>הגדרת רישום</h3>
  <pre><code>
{
  "Serilog": {
    "MinimumLevel": "Information",
    "WriteTo": [
      { "Name": "File", "Args": { "path": "logs/log.txt", "rollingInterval": "Day" } }
    ]
  }
}
  </code></pre>
  <img src="https://via.placeholder.com/600x300?text=Logging" alt="Logging">
</div>

<div id="בדיקה">
  <h2>בדיקה ✅</h2>
  <p>מבחני יחידה נכתבים באמצעות xUnit וממוקמים בפרויקט Tests.</p>
  
  <h3>הפעלת מבחנים</h3>
  <pre><code>dotnet test</code></pre>
  <img src="https://via.placeholder.com/600x300?text=Testing" alt="Testing">
</div>

<div id="תורם">
  <h2>תורם 🤝</h2>
  <p>תרומות יתקבלו בברכה! אנא בצע את השלבים הבאים כדי לתרום:</p>
  <ol>
    <li>מזלג את המאגר.</li>
    <li>צור ענף תכונה חדש.</li>
    <li>בצע את השינויים שלך.</li>
    <li>שלח בקשת משיכה עם תיאור מפורט של השינויים שלך.</li>
  </ol>
  <img src="https://via.placeholder.com/600x300?text=Contributing" alt="Contributing">
</div>

<div id="רישיון">
  <h2>רישיון 📜</h2>
  <p>פרויקט זה מורשה תחת רישיון MIT. עיין בקובץ LICENSE לפרטים.</p>
</div>

<div id="תודות">
  <h2>תודות 🙏</h2>
  <p>תודה מיוחדת לצוותי ASP.NET Core ו-Entity Framework Core על מתן מסגרות מצוינות. תודה לכל התורמים שעזרו לשפר את הפרויקט הזה.</p>
  <img src="https://via.placeholder.com/600x300?text=Thank+You" alt="Thank You">
</div>
