using System;
using System.Text;

namespace SongEncryption
{
    public class SongEncryption
    {
        public static void Main()
        {
            while (true)
            {
                string line = Console.ReadLine();
                if (line == "end")
                {
                    break;
                }

                // "{artist}:{song}"
                string[] lineTokens = line.Split(':', StringSplitOptions.RemoveEmptyEntries);
                string artist = lineTokens[0];
                string song = lineTokens[1];

                bool isValidArtist = Validate("artist", artist);
                bool isValidSong = Validate("song", song);

                if (isValidArtist && isValidSong)
                {
                    int key = artist.Length;
                    StringBuilder encryptedArtist = new StringBuilder();
                    StringBuilder encryptedSong = new StringBuilder();

                    char artistFirstLetter = artist[0];
                    char encrArtistFirstLetter = (char)(artistFirstLetter + key);
                    if (encrArtistFirstLetter > 90)
                    {
                        int diff = 90 - artistFirstLetter;
                        key -= diff;
                        encrArtistFirstLetter = (char)('A' + key);
                    }

                    encryptedArtist.Append(encrArtistFirstLetter);

                    // encrypt artist
                    for (int i = 1; i < artist.Length; i++)
                    {
                        char currentChar = line[i];
                        char encryptedChar = (char)(currentChar + key);
                        if (encryptedChar > 122)
                        {
                            int diff = encryptedChar - 122;
                            encryptedChar = (char)('a' + diff - 1);
                        }

                        if (currentChar == ' ')
                        {
                            encryptedChar = ' ';
                        }

                        if (currentChar == '\'')
                        {
                            encryptedChar = '\'';
                        }

                        encryptedArtist.Append(encryptedChar);
                    }

                    // encrypt song
                    for (int i = 0; i < song.Length; i++)
                    {
                        char currentChar = song[i];
                        char encryptedChar = (char)(currentChar + key);
                        if (encryptedChar > 90)
                        {
                            int diff = encryptedChar - 90;
                            encryptedChar = (char)('A' + diff - 1);
                        }

                        if (currentChar == ' ')
                        {
                            encryptedChar = ' ';
                        }

                        encryptedSong.Append(encryptedChar);
                    }

                    string encriptedLine = encryptedArtist.ToString();
                    encriptedLine += "@";
                    encriptedLine += encryptedSong.ToString();
                    Console.WriteLine($"Successful encryption: {encriptedLine.ToString()}");
                }
                else
                {
                    Console.WriteLine($"Invalid input!");
                }
            }
        }

        private static bool Validate(string command, string stringToValidate)
        {
            if (command == "artist")
            {
                // starts with capital letter, followed by lowercase letters
                // It can also contains apostrophe ( ' ), and whitespace " "; 
                // Valid group name: Red hot chili peppers, Eminem, Guns n' roses
                // Invalid group name: ReD Hot CiLly PePers, sLipKnot, guns n'roses
                char firstLetter = stringToValidate[0];
                if (firstLetter >= 65 && firstLetter <= 90)
                {
                    for (int i = 1; i < stringToValidate.Length; i++)
                    {
                        char currentChar = stringToValidate[i];
                        if (!char.IsLower(currentChar) && currentChar != '\'' && currentChar != ' ')
                        {
                            return false;
                        }
                    }

                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                // contains only capital letters, and whitespaces.
                // Valid songs: BACK IN BLACK, BLEED IT OUT, KILLSHOT
                // Invalid songs: #BaCk IN black, BLEED $IT$ OUTt, &KILLSHoT
                foreach (var symbol in stringToValidate)
                {
                    if (!char.IsUpper(symbol) && symbol != ' ')
                    {
                        return false;
                    }
                }

                return true;
            }
        }
    }
}
