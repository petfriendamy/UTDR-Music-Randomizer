using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTDRMusicRandomizer
{
    public static class UTDRRandomizer
    {
        private static string[] SpeedrunIllegalSongs = new string[]
        {
            "cyber", "mansion"
        };

        private static string[] CreditsSongsDeltarune = new string[]
        {
            "dontforget", "ch2_credits"
        };

        private static string[] CreditsSongsUndertale = new string[]
        {
            "mus_cast_1", "mus_cast_2", "mus_cast_3", "mus_cast_4",
            "mus_cast_5", "mus_cast_6", "mus_cast_7", "mus_express_myself"
        };

        private static string[] FloweyFightSongs = new string[]
        {
            "mus_f_intro", "mus_f_part1", "mus_f_part2", "mus_f_part3",
            "mus_repeat_1", "mus_repeat_2", "mus_f_6s_1", "mus_f_6s_2",
            "mus_f_6s_3", "mus_f_6s_4", "mus_f_6s_5", "mus_f_6s_6",
            "mus_f_saved", "mus_f_finale_1", "mus_f_finale_1_l",
            "mus_f_finale_2", "mus_f_finale_3",
        };

        private static string[] AmbienceDeltarune = new string[]
        {
            "alley_ambience", "audio_drone", "bird", "deep_noise", "elevator",
            "honksong", "mus_birdnoise", "ocean", "shinkansen", "sink_noise",
            "w", "wind_highplace", "wind"
        };

        private static string[] AmbienceUndertale = new string[]
        {
            "mus_ambientwater", "mus_barrier", "mus_bgflamea", "mus_birdnoise",
            "mus_core_ambience", "mus_crickets", "mus_deeploop2", "mus_drone",
            "mus_elevator", "mus_elevator_last", "mus_f_wind1", "mus_f_wind2",
            "mus_oogloop", "mus_rain", "mus_rain_deep", "mus_tone2", "mus_tone3",
            "mus_wind", "mus_zzz_c", "mus_zzz_c2"
        };

        private static string[] SoundsDeltarune = new string[]
        {
            "berdly_audience", "berdly_descend", "charjoined", "cyber_battle_end",
            "fanfare", "queen_intro", "s_neo_clip", "spamton_laugh_noise",
            "static_placeholder", "tv_noise"
        };

        private static string[] SoundsUndertale = new string[]
        {
            "abc_123_a", "mus_alphysfix", "mus_bergentruckung", "mus_churchbell",
            "mus_computer", "mus_cymbal", "mus_dogmeander", "mus_doorclose",
            "mus_dooropen", "mus_drone", "mus_dununnn", "mus_f_alarm", "mus_f_destroyed",
            "mus_f_destroyed2", "mus_f_destroyed3", "mus_f_newlaugh", "mus_f_newlaugh_low",
            "mus_fearsting", "mus_harpnoise", "mus_intronoise", "mus_mett_applause",
            "mus_mett_cheer", "mus_mode", "mus_myemeow", "mus_ohyes", "mus_rimshot",
            "mus_sfx_a_grab", "mus_sfx_chainsaw", "mus_sfx_hypergoner_charge",
            "mus_sfx_hypergoner_laugh", "mus_sfx_hypergoner_hold", "mus_snowwalk",
            "mus_sticksnap", "mus_wawa", "mus_whoopee", "snd_ballchime", "snd_bombfall",
            "snd_bombsplosion", "snd_buzzing", "snd_curtgunshot", "snd_fall2", "snd_flameloop",
            "snd_heavydamage", "snd_mushroomdance"
        };

        private struct SongFile
        {
            public SongFile(string name, bool fromBaseFolder = false)
            {
                Name = name;
                FromBaseFolder = fromBaseFolder;
            }
            public string Name { get; }
            public bool FromBaseFolder { get; }
        }

        public static bool IsValidPath(string path)
        {
            if (Directory.Exists(path))
            {
                if (File.Exists(path + @"\UNDERTALE.exe"))
                {
                    return true;
                }
                else if (File.Exists(path + @"\DELTARUNE.exe") && Directory.Exists(path + @"\mus"))
                {
                    return true;
                }
                else if (IsMac(path) || IsLinux(path))
                {
                    return true;
                }
                return false;
            }
            return false;
        }

        public static bool IsDeltarune(string basePath)
        {
            return File.Exists(basePath + @"\DELTARUNE.exe") || Path.GetFileName(basePath) == "DELTARUNE.app";
        }

        public static bool IsMac(string basePath)
        {
            return (Path.GetFileName(basePath) == "UNDERTALE.app" || Path.GetFileName(basePath) == "DELTARUNE.app"
                || Path.GetFileName(basePath) == "SURVEY_PROGRAM.app") && Directory.Exists(basePath + "/Contents");
        }

        public static bool IsLinux(string basePath)
        {
            return File.Exists(basePath + "/run.sh") && Directory.Exists(basePath + "/assets");
        }

        private static char GetSeparator(string basePath)
        {
            if (IsMac(basePath) || IsLinux(basePath))
            {
                return '/';
            }
            else
            {
                return '\\';
            }
        }

        private static string GetBasePath(string installPath)
        {
            string basePath = installPath;
            if (IsMac(installPath))
            {
                basePath += "/Contents/Resources";
            }
            else if (IsLinux(installPath))
            {
                basePath += "/assets";
            }
            return basePath;
        }

        private static string GetMusicPath(string basePath)
        {
            string musicPath = GetBasePath(basePath);
            if (IsDeltarune(basePath))
            {
                musicPath += GetSeparator(basePath) + "mus";
            }
            return musicPath;
        }

        private static string GetBackupPath(string basePath)
        {
            return GetMusicPath(basePath) + GetSeparator(basePath) + "backup";
        }

        public static bool BackupFolderExists(string basePath)
        {
            return Directory.Exists(GetBackupPath(basePath));
        }

        public static RandoResult Randomize(string basePath, RandoOptions options, bool makeBackup)
        {
            string musicPath = GetMusicPath(basePath);
            bool isDeltarune = IsDeltarune(basePath);
            string[] files = Directory.GetFiles(musicPath);
            IEnumerable<string> oggFiles;
            if (isDeltarune)
            {
                oggFiles =
                    from f in files
                    where Path.GetExtension(f) == ".ogg"
                    where (options.SpeedrunLegal ? true : !SpeedrunIllegalSongs.Contains(Path.GetFileNameWithoutExtension(f).ToLower()))
                    where (options.CyberBattle ? true : Path.GetFileNameWithoutExtension(f) != "cyber_battle_prelude")
                    where (options.CreditsSongs ? true : !CreditsSongsDeltarune.Contains(Path.GetFileNameWithoutExtension(f).ToLower()))
                    where (options.Ambience ? true : !AmbienceDeltarune.Contains(Path.GetFileNameWithoutExtension(f).ToLower()))
                    where (options.SFX ? true : !SoundsDeltarune.Contains(Path.GetFileNameWithoutExtension(f).ToLower()))
                    select f;
            }
            else //Undertale
            {
                oggFiles =
                    from f in files
                    where Path.GetExtension(f) == ".ogg"
                    where Path.GetFileNameWithoutExtension(f) != "mus_silence"
                    where Path.GetFileNameWithoutExtension(f) != "mus_story_stuck"
                    where (options.MultiPart ? true : !FloweyFightSongs.Contains(Path.GetFileNameWithoutExtension(f).ToLower()))
                    where (options.CreditsSongs ? true : !CreditsSongsUndertale.Contains(Path.GetFileNameWithoutExtension(f).ToLower()))
                    where (options.Ambience ? true : !AmbienceUndertale.Contains(Path.GetFileNameWithoutExtension(f).ToLower()))
                    where (options.SFX ? true : !SoundsUndertale.Contains(Path.GetFileNameWithoutExtension(f).ToLower()))
                    select f;
            }

            if (!oggFiles.Any())
            {
                return new RandoResult("No valid OGG files found.", false);
            }
            else
            {
                try //attempt to make a backup folder
                {
                    string temp = GetBackupPath(basePath), backupFilePath;
                    char separator = GetSeparator(basePath);
                    var backupFolder = Directory.CreateDirectory(temp);

                    try //attempt to move files to the backup folder
                    {
                        var tempNames = new List<SongFile>();

                        foreach (var f in oggFiles)
                        {
                            temp = Path.GetFileName(f);
                            backupFilePath = backupFolder.FullName + separator + temp;
                            tempNames.Add(new SongFile(temp));
                            if (makeBackup || !File.Exists(backupFilePath))
                            {
                                File.Delete(backupFilePath);
                                File.Move(f, backupFilePath);
                            }
                            else
                            {
                                File.Delete(f);
                            }
                        }

                        if (isDeltarune && options.SFX) //grab SFX from base folder
                        {
                            var drFiles = Directory.GetFiles(GetBasePath(basePath));
                            var drSounds =
                                from f in drFiles
                                where Path.GetExtension(f) == ".ogg"
                                select f;

                            foreach (var f in drSounds)
                            {
                                temp = Path.GetFileName(f);
                                backupFilePath = backupFolder.FullName + separator + temp;
                                tempNames.Add(new SongFile(temp, true));
                                if (makeBackup || !File.Exists(backupFilePath))
                                {
                                    File.Delete(backupFilePath);
                                    File.Move(f, backupFilePath);
                                }
                                else
                                {
                                    File.Delete(f);
                                }
                            }
                        }

                        var rng = new Random();
                        int i = 0;
                        string tempPath;
                        foreach (var f in backupFolder.GetFiles())
                        {
                            tempPath = (musicPath + separator + f.Name).Replace($"{separator}{separator}", $"{separator}");
                            if (oggFiles.Contains(tempPath) || (isDeltarune && options.SFX &&
                                (f.Name.StartsWith("snd_") || f.Name.StartsWith("audio_intronoise"))))
                            {
                                do
                                {
                                    i = rng.Next(tempNames.Count);
                                } while (tempNames[i].Name == Path.GetFileName(f.Name));

                                if (tempNames[i].FromBaseFolder)
                                {
                                    temp = basePath + separator + tempNames[i].Name;
                                }
                                else
                                {
                                    temp = musicPath + separator + tempNames[i].Name;
                                }
                                File.Copy(f.FullName, temp);
                                tempNames.RemoveAt(i);
                            }
                        }

                        temp = "Randomization complete!";
                        if (makeBackup)
                        {
                            temp += " Original files were copied to ";
                            if (IsMac(basePath))
                            {
                                temp += "/Contents/Resources";
                                if (isDeltarune) { temp += "/mus"; }
                                temp += "/backup";
                            }
                            else if (IsLinux(basePath)) { temp += "/assets/backup"; }
                            else
                            {
                                if (isDeltarune) { temp += @"\mus"; }
                                temp += @"\backup";
                            }
                        }
                        return new RandoResult(temp, true);
                    }
                    catch //something went wrong while moving files
                    {
                        //attempt to restore from backup
                        bool restored = RestoreFromBackup(musicPath);
                        if (restored)
                        {
                            return new RandoResult("An error ocurred while randomizing. Files were recovered from backup.", false);
                        }
                        else //something went wrong while restoring the backup
                        {
                            return new RandoResult("A fatal error occurred, and data could not be recovered. Please reinstall the game.", false);
                        }
                    }
                }
                catch //failed to make backup folder
                {
                    return new RandoResult("Failed to make backup folder. Please check your write permissions.", false);
                }
            }
        }

        public static bool RestoreFromBackup(string basePath)
        {
            try
            {
                string musicPath = GetMusicPath(basePath), backupPath = GetBackupPath(basePath);
                bool isDeltarune = IsDeltarune(basePath);
                foreach (var f in Directory.GetFiles(backupPath))
                {
                    string destPath = musicPath, fileName = Path.GetFileName(f);
                    if (isDeltarune && (fileName.StartsWith("snd_") || fileName.ToLower().StartsWith("audio_intronoise")))
                    {
                        destPath = GetBasePath(basePath);
                    }
                    destPath += GetSeparator(basePath) + fileName;

                    if (File.Exists(destPath))
                    {
                        File.Delete(destPath);
                    }
                    File.Copy(f, destPath);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
