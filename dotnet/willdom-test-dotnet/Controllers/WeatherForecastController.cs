using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace willdom_test_dotnet.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ArticleController : ControllerBase
    {
        private readonly List<Article> articles = new List<Article>();
        public ArticleController()
        {            
            articles.Add(new Article()
            {
                title = "Galaxy Watch 4: 48 hours with Samsung's new smartwatch",
                description = "Wear OS, body analysis, snore tracking, Bixby, rotating bezels and lots of nice watch faces -- here are some observations on living with Samsung's newest watches so far.",
                content = "Drew Evans/CNET\nTrying the latest Galaxy Watch 4, unveiled earlier this week at Samsung's August Unpacked event, feels like a peek at where Android watches are heading. The Samsung watch is the first with Google's newest version of its Wear OS, and i... [9490 chars]",
                url = "https://www.cnet.com/tech/mobile/galaxy-watch-4-48-hours-samsungs-new-smartwatch/",
                image = "https://www.cnet.com/a/img/SDyWGvDvYbfDht1kysWc6kbVOwg=/1200x630/2021/08/11/7a13f2f5-5d21-4de8-9262-1dee5dc8b395/samsung-galaxy-watch-4-and-watch-4-classic-21.jpg",
                publishedAt = "2021-08-15T21:50:52Z",
            });
            articles.Add(new Article()
            {
                title = "Gurman: Apple Planning Multiple Events for the Fall, M1X MacBook Pros to be Available by November",
                description = "Apple is planning to hold multiple events this fall, which will collectively include the launch of new iPhones, Apple Watches, updated AirPods,...",
                content = "Apple is planning to hold multiple events this fall, which will collectively include the launch of new iPhones, Apple Watches, updated AirPods, revamped iPad mini, and the redesigned MacBook Pros, according to respected Bloomberg journalist Mark Gurm... [2177 chars]",
                url = "https://www.macrumors.com/2021/08/15/gurman-multiple-fall-events-m1x-macbook-pros/",
                image = "https://images.macrumors.com/t/YeSWFu-rX6om4IaLePwz619MraE=/3056x/https://images.macrumors.com/article-new/2021/04/tim-cook-spring-loaded-event.jpg",
                publishedAt = "2021-08-15T19:07:28Z",
            });
            articles.Add(new Article()
            {
                title = "WATCH: Celtics Legend Larry Bird Once Shocked Michael Jordan With His Insane Skills",
                description = "In a major rewind to 1988, Bulls legend Michael Jordan watches in amazement as Celtics' Larry Bird puts on a flawless shooting display.",
                content = "Published 08/16/2021, 12:34 PM EDT\nThe three-point contest has been an entertaining tradition in the NBA. Some of the league’s best shooters have been a feature of the competition. Players are assigned a designated period of time, within which they m... [2475 chars]",
                url = "https://www.essentiallysports.com/nba-basketball-news-watch-celtics-legend-larry-bird-once-shocked-michael-jordan-with-his-insane-skills/",
                image = "https://image-cdn.essentiallysports.com/wp-content/uploads/20210316180027/GettyImages-456129594.jpg",
                publishedAt = "2021-08-16T16:34:57Z",
            });
            articles.Add(new Article()
            {
                title = "Match Report & Highlights",
                description = "Match report and free highlights as Heung-Min Son seals morale-boosting victory for Tottenham against Premier League champions Manchester City; Harry Kane watches on from the stands as Spurs make their point",
                content = "Nuno Espirito Santo's Tottenham reign got off to the perfect start as his side shocked champions Manchester City with a 1-0 win courtesy of Heung-Min Son's second-half strike on a pulsating Super Sunday.\nWith the preamble to this standout fixture in ... [7790 chars]",
                url = "https://www.skysports.com/football/tottenham-vs-man-city/report/446296",
                image = "https://www.skysports.com/assets/favicon.ico",
                publishedAt = "2021-08-15T17:40:00Z",
            });
        }

        [HttpGet]
        public IEnumerable<Article> Get()
        {
            return articles;
        }
    }
}
