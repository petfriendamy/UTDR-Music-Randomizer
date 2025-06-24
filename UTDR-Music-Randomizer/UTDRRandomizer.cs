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
            "dontforget", "ch2_credits", "ch4_credits"
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
            "alley_ambience", "audio_drone", "bell_ambience", "bird", "board_ocean",
            "carol_appeared", "church_lightning", "deep_noise", "elevator", "heartbeat",
            "honksong", "knight_appears", "muffled_rain", "mus_birdnoise",
            "mus_knightthought", "night_ambience", "noelleshouseoutside", "ocean", "raining",
            "raining_in_church2", "shinkansen", "sink_noise", "strongwind_loop",
            "tv_infrontof", "w", "wind_highplace", "wind"
        };

        private static string[] AmbienceUndertale = new string[]
        {
            "mus_ambientwater", "mus_barrier", "mus_bgflamea", "mus_birdnoise",
            "mus_core_ambience", "mus_crickets", "mus_deeploop2", "mus_drone",
            "mus_elevator", "mus_elevator_last", "mus_f_wind1", "mus_f_wind2",
            "mus_oogloop", "mus_rain", "mus_rain_deep", "mus_tone2", "mus_tone3",
            "mus_wind", "mus_zzz_c", "mus_zzz_c2"
        };

        private static string[] RhythmGameSongs = new string[]
        {
            "battle_preview", "battle_preview_crisp", "board4_rhythm",
            "boxing_boss_preview", "boxing_boss_preview_crisp",
            "ch3_karaoke_example_guit_only", "ch3_karaoke_example_guitar_only_v2",
            "ch3_karaoke_example_noguit", "ch3_karaoke_example_noguitar_v2",
            "ch3_karaoke_example_together_ex", "ch3_karaoke_full",
            "ch3_karaoke_no_guitar", "ch3_karaoke_preview",
            "ch3_karaoke_preview_crisp", "ch3_tvtime_guitar",
            "ch3-practice_song_combined", "ch3-practice_song_noguit",
            "field_of_hopes_preview", "field_of_hopes_preview_crisp",
            "rhythm_knockdown_combined", "rhythm_knockdown_no_guit",
            "tenna_battle_guitar", "tenna_battle_preview", "tenna_battle_preview_crisp"
        };

        private static string[] SoundsDeltarune = new string[]
        {
            "berdly_audience", "berdly_descend", "board_lancer_dig", "charjoined",
            "ch4_first_intro", "ch4_first_intro_breaking", "cyber_battle_end",
            "fanfare", "me", "ominous_message", "ominous_stab_harsh", "ominous_stab_harsh_2",
            "ominous_worse", "pianpian", "queen_intro", "rtenna_zoom", "s_neo_clip",
            "sadchord2", "sinedrone_danger", "sinedrone_danger_high", "sound_battle_bg",
            "statue_chord_basic", "statue_level1", "statue_level2", "statue_level4",
            "statue2_level1", "statue2_level2", "statue2_level3", "statue2_level4",
            "statue2_level5", "spamton_laugh_noise", "static_placeholder", "tinnitus",
            "tv_noise", "tv_static_bad", "wet_tapdancing", "wet_tapdancing_failed",
            "wet_tapdancing2"
        };

        private static string[] SoundsUndertale = new string[]
        {
            "abc_123_a", "mus_alphysfix", "mus_churchbell", "mus_computer", "mus_cymbal",
            "mus_dogmeander", "mus_doorclose", "mus_dooropen", "mus_drone", "mus_dununnn",
            "mus_f_alarm", "mus_f_destroyed", "mus_f_destroyed2", "mus_f_destroyed3",
            "mus_f_newlaugh", "mus_f_newlaugh_low", "mus_fearsting", "mus_harpnoise",
            "mus_intronoise", "mus_mett_applause", "mus_mett_cheer", "mus_mode", "mus_myemeow",
            "mus_ohyes", "mus_rimshot", "mus_sfx_a_grab", "mus_sfx_chainsaw",
            "mus_sfx_hypergoner_charge", "mus_sfx_hypergoner_laugh", "mus_sfx_hypergoner_hold",
            "mus_snowwalk", "mus_sticksnap", "mus_wawa", "mus_whoopee", "snd_ballchime",
            "snd_bombfall", "snd_bombsplosion", "snd_buzzing", "snd_curtgunshot", "snd_fall2",
            "snd_flameloop", "snd_heavydamage", "snd_mushroomdance"
        };

        private struct SongFile
        {
            public SongFile(string name, bool fromBaseFolder = false, int chapter = 0)
            {
                Name = name;
                FromBaseFolder = fromBaseFolder;
                Chapter = chapter;
            }
            public string Name { get; }
            public bool FromBaseFolder { get; }
            public int Chapter { get; }
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

        private static string GetChapterPath(string basePath, int chapter)
        {
            string path = GetBasePath(basePath);
            string platform = "windows";
            if (IsMac(basePath)) { platform = "mac"; }
            return path + GetSeparator(basePath) + $"chapter{chapter}_{platform}";
        }

        private static string GetBackupPath(string basePath)
        {
            return GetMusicPath(basePath) + GetSeparator(basePath) + "backup";
        }

        public static bool BackupFolderExists(string basePath)
        {
            return Directory.Exists(GetBackupPath(basePath));
        }

        private static bool IsFromBaseFolder(string name)
        {
            return name.StartsWith("snd_") || name.ToLower().StartsWith("audio_intronoise") ||
                name.StartsWith("mus_undynescary");
        }

        public static RandoResult Randomize(string basePath, RandoOptions options, bool makeBackup)
        {
            string musicPath = GetMusicPath(basePath);
            bool isDeltarune = IsDeltarune(basePath);
            string[] files = Directory.GetFiles(musicPath);
            IEnumerable<string> oggFiles;
            int i;

            if (isDeltarune)
            {
                oggFiles =
                    from f in files
                    where Path.GetExtension(f) == ".ogg"
                    where (options.SpeedrunLegal ? true : !SpeedrunIllegalSongs.Contains(Path.GetFileNameWithoutExtension(f).ToLower()))
                    where (options.CyberBattle ? true : Path.GetFileNameWithoutExtension(f) != "cyber_battle_prelude")
                    where (options.CreditsSongs ? true : !CreditsSongsDeltarune.Contains(Path.GetFileNameWithoutExtension(f).ToLower()))
                    where (options.Ambience ? true : !AmbienceDeltarune.Contains(Path.GetFileNameWithoutExtension(f).ToLower()))
                    where (options.RhythmGame ? true : !RhythmGameSongs.Contains(Path.GetFileNameWithoutExtension(f)))
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
                            //check if chapters are separated (newer versions of Deltarune)
                            if (Path.Exists(GetChapterPath(basePath, 1)))
                            {
                                for (i = 1; i <= 7; ++i)
                                {
                                    string path = GetChapterPath(basePath, i);
                                    if (Path.Exists(path))
                                    {
                                        var chFiles = Directory.GetFiles(path);
                                        var sounds = (from f in chFiles
                                            where Path.GetExtension(f) == ".ogg"
                                            select f);

                                        foreach (var f in sounds)
                                        {
                                            temp = Path.GetFileName(f);
                                            backupFilePath = backupFolder.FullName + separator + temp;
                                            tempNames.Add(new SongFile(temp, true, i));
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
                                }
                            }
                            else //if not, get files from the base folder
                            {
                                var drFiles = Directory.GetFiles(GetBasePath(basePath));
                                var sounds = (from f in drFiles
                                    where Path.GetExtension(f) == ".ogg"
                                    select f);

                                foreach (var f in sounds)
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
                        }

                        var rng = new Random();
                        i = 0;
                        string tempPath;
                        foreach (var f in backupFolder.GetFiles())
                        {
                            tempPath = (musicPath + separator + f.Name).Replace($"{separator}{separator}", $"{separator}");
                            if (oggFiles.Contains(tempPath) || (isDeltarune && options.SFX && IsFromBaseFolder(f.Name)))
                            {
                                do
                                {
                                    i = rng.Next(tempNames.Count);
                                } while (tempNames[i].Name == Path.GetFileName(f.Name));

                                if (tempNames[i].Chapter > 0)
                                {
                                    temp = GetChapterPath(basePath, tempNames[i].Chapter) + separator + tempNames[i].Name;
                                }
                                else if (tempNames[i].FromBaseFolder)
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
                bool isDeltarune = IsDeltarune(basePath), checkAllChapters;

                foreach (var f in Directory.GetFiles(backupPath))
                {
                    string destPath = musicPath, fileName = Path.GetFileName(f);
                    checkAllChapters = false;
                    if (isDeltarune && IsFromBaseFolder(fileName))
                    {
                        destPath = GetBasePath(basePath);
                        checkAllChapters = Path.Exists(GetChapterPath(basePath, 1));
                    }

                    if (checkAllChapters) //copy this file to each chapter that has it
                    {
                        for (int i = 1; i <= 7; ++i)
                        {
                            destPath = GetChapterPath(basePath, i);
                            if (Path.Exists(destPath))
                            {
                                destPath += GetSeparator(basePath) + fileName;

                                if (File.Exists(destPath))
                                {
                                    File.Delete(destPath);
                                    File.Copy(f, destPath);
                                }
                            }
                        }
                    }
                    else //just copy it to the correct folder
                    {
                        destPath += GetSeparator(basePath) + fileName;

                        if (File.Exists(destPath))
                        {
                            File.Delete(destPath);
                        }
                        File.Copy(f, destPath);
                    }
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
