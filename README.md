# Asset Tracking with database Using Entity Framework Core<br/>
***This project is the start of an Asset Tracking database.***<br/>
Asset Tracking is a way to keep track of the company assets, like Laptops, Stationary computers, phones<br/>
All assets have an end life which for simplicity reasons is 3 years.<br/>
All assets are stored in database using ***Entity Framework Core***. One can ***Post*** Data and ***Get*** Data from the Database.<br/>
It has 4 different offices around the world which will use the appropriate ***currency*** for that country. The program is able to input values in dollars and convert them to each currency (based on todays currency charts). Built in methods were used to get the ***currency rates*** in Euro, Dollar, SEK, NOK.<br/>
Default Data has also been used in the Database so the database is not empty. <br/>

1. The Table is shown to the console and also in the **Microsoft SQL Server**:
  * Sorted first by office :heavy_check_mark:
  * Then Purchase date :heavy_check_mark:
  * Items *RED* if date less than 3 months away from 3 years :heavy_check_mark:
  * Items *Yellow* if date less than 6 months away from 3 years :heavy_check_mark:
  * Each item should have currency according to the country :heavy_check_mark:
  * Extra Feature has also been added in this project, in which products will be shown depending on the Country. :heavy_check_mark: <br/> <br/>![anotherone](https://user-images.githubusercontent.com/73182090/171579979-bea1ef01-d595-47d4-aba4-b290dc051ce9.png)
