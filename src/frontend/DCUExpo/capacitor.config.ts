import { CapacitorConfig } from '@capacitor/cli';

const config: CapacitorConfig = {
  appId: 'io.ionic.starter',
  appName: 'DCUExpo',
  webDir: 'www',
  server: {
    androidScheme: 'http',
    allowNavigation: []
  },
  android: {
    allowMixedContent: true
  }
};

export default config;
