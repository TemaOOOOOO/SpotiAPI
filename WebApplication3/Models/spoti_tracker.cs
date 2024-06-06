namespace WebApplication3.Models
{

    public class AlbumModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Artist { get; set; }
    }

    public class AlbumOfTrack
    {
        public string uri { get; set; }
        public string name { get; set; }
        public CoverArt coverArt { get; set; }
        public string id { get; set; }
        public SharingInfo sharingInfo { get; set; }
    }

    public class Albums
    {
        public int totalCount { get; set; }
        public List<Item> items { get; set; }

       
    }

    public class Artists
    {
        public List<Item> items { get; set; }
        public int totalCount { get; set; }
    }

    public class AvatarImage
    {
        public List<Source> sources { get; set; }
    }

    public class ContentRating
    {
        public string label { get; set; }
    }

    public class CoverArt
    {
        public List<Source> sources { get; set; }
    }

    public class Data
    {
        public string uri { get; set; }
        public string name { get; set; }
        public Artists artists { get; set; }
        public CoverArt coverArt { get; set; }
        public Date date { get; set; }
        public Profile profile { get; set; }
        public Visuals visuals { get; set; }
        public Duration duration { get; set; }
        public ReleaseDate releaseDate { get; set; }
        public Podcast podcast { get; set; }
        public string description { get; set; }
        public ContentRating contentRating { get; set; }
        public Images images { get; set; }
        public Owner owner { get; set; }
        public string type { get; set; }
        public Publisher publisher { get; set; }
        public string mediaType { get; set; }
        public string id { get; set; }
        public AlbumOfTrack albumOfTrack { get; set; }
        public Playability playability { get; set; }
        public string displayName { get; set; }
        public string username { get; set; }
        public Image image { get; set; }
    }

    public class Date
    {
        public int year { get; set; }
    }

    public class Duration
    {
        public int totalMilliseconds { get; set; }
    }

    public class Episodes
    {
        public int totalCount { get; set; }
        public List<Item> items { get; set; }
    }

    public class Featured
    {
        public Data data { get; set; }
    }

    public class Genres
    {
        public int totalCount { get; set; }
        public List<object> items { get; set; }
    }

    public class Image
    {
        public string smallImageUrl { get; set; }
        public string largeImageUrl { get; set; }
    }

    public class Images
    {
        public List<Item> items { get; set; }
    }

    public class Item
    {
        public Data data { get; set; }
        public List<Source> sources { get; set; }
        public string uri { get; set; }
        public Profile profile { get; set; }
    }

    public class Owner
    {
        public string name { get; set; }
    }

    public class Playability
    {
        public bool playable { get; set; }
    }

    public class Playlists
    {
        public int totalCount { get; set; }
        public List<Item> items { get; set; }
    }

    public class Podcast
    {
        public CoverArt coverArt { get; set; }
    }

    public class Podcasts
    {
        public int totalCount { get; set; }
        public List<Item> items { get; set; }
    }

    public class Profile
    {
        public string name { get; set; }
    }

    public class Publisher
    {
        public string name { get; set; }
    }

    public class ReleaseDate
    {
        public DateTime isoString { get; set; }
    }

    public class spoti_tracker
    {
        public Albums albums { get; set; }
        public Artists artists { get; set; }
        public Episodes episodes { get; set; }
        public Genres genres { get; set; }
        public Playlists playlists { get; set; }
        public Podcasts podcasts { get; set; }
        public TopResults topResults { get; set; }
        public Tracks tracks { get; set; }
        public Users users { get; set; }

       
    }
    
   
    public class SharingInfo
    {
        public string shareUrl { get; set; }
    }

    public class Source
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }

    public class TopResults
    {
        public List<Item> items { get; set; }
        public List<Featured> featured { get; set; }
    }

    public class Tracks
    {
        public int totalCount { get; set; }
        public List<Item> items { get; set; }
    }

    public class Users
    {
        public int totalCount { get; set; }
        public List<Item> items { get; set; }
    }

    public class Artist2
    {
        public string name { get; set; }
        public string image { get; set; }
        public string uri { get; set; }

        public Artist2 (string name, string image, string uri)
        {
            this.name = name;
            this.image = image;
            this.uri = uri;
        }
    }
    public class Visuals
    {
        public AvatarImage avatarImage { get; set; }
    }

}