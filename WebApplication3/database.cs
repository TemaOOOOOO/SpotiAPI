using Microsoft.VisualBasic;
using Npgsql;
using WebApplication3;
using WebApplication3.Models;

namespace WebApplication3
{
    public class Database
    {
        NpgsqlConnection con = new NpgsqlConnection(constant.Connect);

        public async Task AddHistory(Data data)
        {
            var sql = "INSERT INTO public.\"spotibot\" (\"name\", \"image\", \"uri\")"
                    + "VALUES (@name, @image, @uri)";

            NpgsqlCommand comm = new NpgsqlCommand(sql, con);
            comm.Parameters.AddWithValue("name", data.profile.name);
            comm.Parameters.AddWithValue("image", data.visuals.avatarImage.sources[0].url);
            comm.Parameters.AddWithValue("uri", data.uri);


            await con.OpenAsync();
            await comm.ExecuteNonQueryAsync();
            await con.CloseAsync();
        }


        public async Task DeleteHistory(string name)
        {
            var sql = "DELETE FROM public.\"spotibot\" WHERE \"name\" = @name";

            NpgsqlCommand comm = new NpgsqlCommand(sql, con);
            comm.Parameters.AddWithValue("name", name);

            try
            {
                await con.OpenAsync();
                await comm.ExecuteNonQueryAsync();
            }
            catch (Exception ex)
            {
                
            }
            finally
            {
                con.Close();
            }
        }

        public async Task<List<Artist2>> GetHistory()
        {
            var sql = "select \"name\", \"image\", \"uri\" from public .\"spotibot\"";

            NpgsqlCommand comm = new NpgsqlCommand(sql, con);
            await con.OpenAsync();
            NpgsqlDataReader npgsqlDataReader = await comm.ExecuteReaderAsync();
            List<Artist2> artist2s = new List<Artist2>();
            while (await npgsqlDataReader.ReadAsync())
            {
                artist2s.Add(new Artist2(
                    npgsqlDataReader.GetString(0),
                    npgsqlDataReader.GetString(1),
                    npgsqlDataReader.GetString(2)));
            }
            await con.CloseAsync();
            return artist2s;
        }
    }
}

