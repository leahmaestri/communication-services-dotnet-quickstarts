﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Calling.RecognizeDTMF
{
    /// <summary>
    /// Configuration assoociated with the call.
    /// </summary>
    public class CallConfiguration
    {
        public CallConfiguration(string connectionString, string sourceIdentity, string sourcePhoneNumber,
            string appBaseUrl, string audioFileName, string salesAudioFileName, string marketingAudioFileName, 
            string customerCareAudioFileName, string invalidAudioFileName)
        {
            this.ConnectionString = connectionString;
            this.SourceIdentity = sourceIdentity;
            this.SourcePhoneNumber = sourcePhoneNumber;
            this.AppBaseUrl = appBaseUrl;
            this.AudioFileName = audioFileName;
            this.SalesAudioFileName = salesAudioFileName;
            this.MarketingAudioFileName = marketingAudioFileName;
            this.CustomerCareAudioFileName = customerCareAudioFileName;
            this.InvalidAudioFileName = invalidAudioFileName;
        }

        /// <summary>
        /// The connectionstring of Azure Communication Service resource.
        /// </summary>
        public string ConnectionString { get; private set; }

        /// <summary>
        /// The source identity.
        /// </summary>
        public string SourceIdentity { get; private set; }

        /// <summary>
        /// The phone number associated with the source. 
        /// </summary>
        public string SourcePhoneNumber { get; private set; }

        /// <summary>
        /// The base url of the applicaiton.
        /// </summary>
        private string AppBaseUrl;

        /// <summary>
        /// The audio file name of the play prompt.
        /// </summary>
        public string AudioFileName;

        /// <summary>
        /// The audio file name of the audio when input is 1.
        /// </summary>
        public string SalesAudioFileName;

        /// <summary>
        /// The audio file name of the play prompt.
        /// </summary>
        public string MarketingAudioFileName;

        /// <summary>
        /// The audio file name of the play prompt.
        /// </summary>
        public string CustomerCareAudioFileName;

        /// <summary>
        /// The audio file name of the play prompt.
        /// </summary>
        public string InvalidAudioFileName;

        /// <summary>
        /// The callback url of the application where notification would be received.
        /// </summary>
        public string AppCallbackUrl => $"{AppBaseUrl}/api/recognizedtmf/callback?{EventAuthHandler.GetSecretQuerystring}";

        /// <summary>
        /// The publicly available url of the audio file which would be played as a prompt.
        /// </summary>
        public string AudioFileUrl => $"{AppBaseUrl}/audio/";
    }
}
