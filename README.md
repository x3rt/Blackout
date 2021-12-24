# 079 Blackout
An SCP:SL EXILED plugin allowing 079 to black out the whole facility.
### Config:

```
 - is_enabled: [true/false] # Wether the plugin should run or not  
 - blackout_surface: [true/false] # Wether surface should be blacked out or not
 - blackout_duration: [number] # How long the blackout should last in seconds
 - blackout_cooldown: [number] # Cooldown between uses in seconds
 - cassie_announcement: [text] # Text to announce to the facility when the blackout is active. Leave empty to disable
 - cassie_silent: [true/false] # Wether or not the cassie starting chime should be muted (same as cassie_sl command)
 - minimum_tier: [1-5] # Minimum tier to use blackout command
 - auxillary_drain: [number] # The amount of energy the blackout command will use
 - lock_doors: [true/false] # Wether or not the doors should be locked during the blackout
 ```
