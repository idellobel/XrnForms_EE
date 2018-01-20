using System;
using System.Threading.Tasks;
using AVFoundation;
using B4.EE.DellobelI.Domain.Services.Abstract;
using Foundation;
using Xamarin.Forms;

[assembly: Dependency(typeof(B4.EE.DellobelI.iOS.Services.PlatformSoundPlayer))]

namespace B4.EE.DellobelI.iOS.Services
{
    public class PlatformSoundPlayer : ISoundPlayer
    {
        private AVAudioPlayer backgroundMusic;
        public Task PlaySound()
        {
            var session = AVAudioSession.SharedInstance();
            session.SetCategory(AVAudioSessionCategory.Ambient);
            session.SetActive(true); NSUrl soundUrl = new NSUrl("Sounds/munchausen.mp3");
            NSError err;
            backgroundMusic = new AVAudioPlayer(soundUrl, "mp3", out err);
            backgroundMusic.Play();

            return Task.Delay(0); }

        
    }