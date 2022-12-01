
/*///<summary>
 ////File: Television
 ///Name: Chris Brown
 ////Email: Cbrown36@stumail.northeaststate.edu
 ///Class: CISP1010
 ///Semester: Fall 2022
 ///Lab 13: Object Modeling - Television
 /// </summary>
 */

namespace Lab13
{
    /// <summary>
    /// Models a Television object
    /// </summary>

    internal class Television
    {
        private ushort channel;
        private byte volume;
        private const ushort MIN_CHANNEL = 2;
        private const ushort MAX_CHANNEL = 50;
        private const byte MIN_VOLUME = 0;
        private const byte MAX_VOLUME = 30;
        /// <summary>
        /// Default constructor
        /// </summary>
        
        public Television()
        {
            channel = MIN_CHANNEL;
            volume = 5;
        }
        /// <summary>
        /// Sets the Television channel if it is between a valid range, otherwise does nothing.
        /// This is a more of a classic OOP design and a Channel property could be used instead (see below)
        /// </summary>
        /// <param name="channel">A channel number</param>
        public void SetChannel(ushort channel)
        {
            if (channel >= MIN_CHANNEL && channel <= MAX_CHANNEL)
            {
                this.channel = channel;
            }
        }

        /// <summary>
        /// Here we accomplish the same thing as the SetChannel method above using a property
        /// to expose a private field to outside classes. Here we also get the convenience of creating
        /// a get property in the same block, without creating another GetChannel method
        /// 
        /// Ideally, you would pick one or the other form to have in your code. The property
        /// below is a more C# standard approach.
        /// </summary>
        public ushort Channel
        {
            set
            {
                if (value >= MIN_CHANNEL && value <= MAX_CHANNEL)
                {
                    channel = value;
                }
            }

            get { return channel; }
        }

        /// <summary>
        /// Increments the Television's channel, or if the Television is currently equal to MAX_CHANNEL,
        /// will set the Television's channel to the MIN_CHANNEL
        /// </summary>
        public void ChannelUp()
        {
            if (this.channel == MAX_CHANNEL)
            {
                this.channel = MIN_CHANNEL;
            }
            else
            {
                this.channel++;
            }
        }
        /// <summary>
        /// Decrements the Television's channel, or if the Television is currently equal to MIN_CHANNEL,
        /// will set the Television's channel to the MAX_CHANNEL
        /// </summary>
        public void ChannelDown()
        {
            if (this.channel == MIN_CHANNEL)
            {
                this.channel = MAX_CHANNEL;
            }
            else
            {
                this.channel--;
            }
        }
        ///
        /// This Method increases the volume by 1 incrementally until it is equal to MAX_VOLUME
        /// 
        public void VolumeUP()
        {
            if (this.volume != MAX_VOLUME)
            {
                this.volume++;
            }
        }
        ///
        /// This Method decreases the volume by 1 incrementally until it is equal to MIN_VOLUME
        /// 
        public void VolumeDown()
        {
            if (this.volume != MIN_VOLUME)
            {
                this.volume--;
            }
        }

        /// <summary>
        /// Creates a string representation of the Television
        /// </summary>
        /// <returns>The string representation of the Television</returns>
        override public string ToString()
        {
            //could also use the public get property Channel
            //return $"TV-> current channel: {Channel}" and current volume: {volume};

            return $"TV-> current channel: {channel} current volume: {volume}";
        }
    }
}